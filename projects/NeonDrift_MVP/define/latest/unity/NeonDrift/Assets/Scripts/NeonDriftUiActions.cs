using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public sealed class NeonDriftUiActions : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject gameplayHudRoot;
    [SerializeField] private Text settingsButtonLabel;
    [SerializeField] private AudioSource audioSource;

    private bool soundEnabled;
    private bool audioFeedbackPlayed;
    private AudioClip soundToggleClip;

    public bool SoundEnabled => soundEnabled;
    public bool AudioFeedbackPlayed => audioFeedbackPlayed;
    public bool AudioSourcePresent => audioSource != null;

    private void Awake()
    {
        EnsureAudioSystem();
        InitializeBindings();
    }

    public void Configure(GameObject menuPanel, GameObject hudRoot, Text settingsLabel)
    {
        mainMenuPanel = menuPanel;
        gameplayHudRoot = hudRoot;
        settingsButtonLabel = settingsLabel;
        EnsureAudioSystem();
        InitializeBindings();
    }

    private void EnsureAudioSystem()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
            if (audioSource == null)
            {
                audioSource = gameObject.AddComponent<AudioSource>();
            }
        }

        audioSource.playOnAwake = false;
        audioSource.loop = false;
        audioSource.volume = 0.8f;
        if (soundToggleClip == null)
        {
            soundToggleClip = CreateToneClip("SoundToggleTone", 880f, 0.12f);
        }
    }

    private static AudioClip CreateToneClip(string clipName, float frequency, float duration)
    {
        int sampleRate = 44100;
        int sampleCount = Mathf.CeilToInt(sampleRate * duration);
        float[] samples = new float[sampleCount];
        for (int index = 0; index < sampleCount; index += 1)
        {
            float t = index / (float)sampleRate;
            float envelope = Mathf.Clamp01(1f - (t / duration));
            samples[index] = Mathf.Sin(2f * Mathf.PI * frequency * t) * 0.35f * envelope;
        }

        AudioClip clip = AudioClip.Create(clipName, sampleCount, 1, sampleRate, false);
        clip.SetData(samples, 0);
        return clip;
    }

    private void InitializeBindings()
    {
        BindButton("Start Button", StartGame);
        BindButton("Settings Button", ShowSettingsFeedback);
        BindButton("Pause Button", TogglePause);
        BindButton("Retry Button", Retry);
        BindSteerZone("Left Control Zone", -1f);
        BindSteerZone("Right Control Zone", 1f);
        bool hasStarted = GameSessionController.Instance != null && GameSessionController.Instance.HasStarted;
        SetMenuVisible(!hasStarted);
        SetGameplayHudVisible(hasStarted);
    }

    private void BindButton(string buttonName, UnityEngine.Events.UnityAction action)
    {
        Button button = FindButton(buttonName);
        if (button == null)
        {
            Debug.LogError($"Required UI button missing: {buttonName}");
            return;
        }

        button.onClick.RemoveListener(action);
        button.onClick.AddListener(action);
        button.interactable = true;
    }

    private Button FindButton(string buttonName)
    {
        Button[] buttons = GetComponentsInChildren<Button>(true);
        foreach (Button button in buttons)
        {
            if (button != null && button.name == buttonName)
            {
                return button;
            }
        }
        return null;
    }

    private void BindSteerZone(string buttonName, float direction)
    {
        Button button = FindButton(buttonName);
        if (button == null)
        {
            Debug.LogError($"Required steering zone missing: {buttonName}");
            return;
        }

        EventTrigger trigger = button.GetComponent<EventTrigger>();
        if (trigger == null)
        {
            trigger = button.gameObject.AddComponent<EventTrigger>();
        }
        trigger.triggers.Clear();

        AddTrigger(trigger, EventTriggerType.PointerDown, () => SetSteer(direction));
        AddTrigger(trigger, EventTriggerType.PointerUp, ClearSteer);
        AddTrigger(trigger, EventTriggerType.PointerExit, ClearSteer);
        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(() => NudgeSteer(direction));
    }

    private void AddTrigger(EventTrigger trigger, EventTriggerType eventType, UnityEngine.Events.UnityAction action)
    {
        EventTrigger.Entry entry = new EventTrigger.Entry { eventID = eventType };
        entry.callback.AddListener(_ => action());
        trigger.triggers.Add(entry);
    }

    private void SetSteer(float direction)
    {
        DriftPlayerController player = DriftPlayerController.Instance != null ? DriftPlayerController.Instance : FindObjectOfType<DriftPlayerController>();
        player?.SetUiSteer(direction);
    }

    private void ClearSteer()
    {
        DriftPlayerController player = DriftPlayerController.Instance != null ? DriftPlayerController.Instance : FindObjectOfType<DriftPlayerController>();
        player?.ClearUiSteer();
    }

    private void NudgeSteer(float direction)
    {
        DriftPlayerController player = DriftPlayerController.Instance != null ? DriftPlayerController.Instance : FindObjectOfType<DriftPlayerController>();
        player?.SimulateSteerStep(direction, 0.25f);
    }

    public void StartGame()
    {
        if (mainMenuPanel != null)
        {
            mainMenuPanel.SetActive(false);
        }
        SetGameplayHudVisible(true);
        GameSessionController session = GameSessionController.Instance != null ? GameSessionController.Instance : FindObjectOfType<GameSessionController>();
        session?.StartGame();
    }

    private void SetGameplayHudVisible(bool visible)
    {
        if (gameplayHudRoot != null)
        {
            gameplayHudRoot.SetActive(visible);
        }
    }

    private void SetMenuVisible(bool visible)
    {
        if (mainMenuPanel != null)
        {
            mainMenuPanel.SetActive(visible);
        }
    }

    public void ShowSettingsFeedback()
    {
        soundEnabled = !soundEnabled;
        if (settingsButtonLabel != null)
        {
            settingsButtonLabel.text = soundEnabled ? "SOUND ON" : "SOUND OFF";
        }

        EnsureAudioSystem();
        if (soundEnabled && audioSource != null && soundToggleClip != null)
        {
            audioSource.PlayOneShot(soundToggleClip);
            audioFeedbackPlayed = true;
        }
    }

    public void TogglePause()
    {
        GameSessionController.Instance?.TogglePause();
    }

    public void Retry()
    {
        GameSessionController session = GameSessionController.Instance != null ? GameSessionController.Instance : FindObjectOfType<GameSessionController>();
        session?.Retry();
        SetMenuVisible(false);
        SetGameplayHudVisible(true);
        session = GameSessionController.Instance != null ? GameSessionController.Instance : FindObjectOfType<GameSessionController>();
        session?.StartGame();
    }
}
