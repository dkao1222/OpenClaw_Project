using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public sealed class NeonDriftUiActions : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject gameplayHudRoot;
    [SerializeField] private Text settingsButtonLabel;

    private void Awake()
    {
        BindButton("Start Button", StartGame);
        BindButton("Settings Button", ShowSettingsFeedback);
        BindButton("Pause Button", TogglePause);
        BindButton("Retry Button", Retry);
        BindSteerZone("Left Control Zone", -1f);
        BindSteerZone("Right Control Zone", 1f);
        SetGameplayHudVisible(GameSessionController.Instance != null && GameSessionController.Instance.HasStarted);
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

    public void ShowSettingsFeedback()
    {
        if (settingsButtonLabel != null)
        {
            settingsButtonLabel.text = "SOUND ON";
        }
    }

    public void TogglePause()
    {
        GameSessionController.Instance?.TogglePause();
    }

    public void Retry()
    {
        GameSessionController.Instance?.Retry();
    }
}
