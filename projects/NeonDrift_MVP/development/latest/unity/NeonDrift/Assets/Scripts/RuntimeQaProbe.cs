using System;
using UnityEngine;
using UnityEngine.UI;

public sealed class RuntimeQaProbe : MonoBehaviour
{
    [Serializable]
    public sealed class ProbeSnapshot
    {
        public string screenState;
        public int screenWidth;
        public int screenHeight;
        public string safeArea;
        public bool hasCanvas;
        public bool hasScoreText;
        public bool hasPulseText;
        public bool hasControlHint;
        public bool hasMainMenuPanel;
        public bool hasStartButton;
        public bool hasSettingsButton;
        public bool hasBestScoreText;
        public bool hasPauseButton;
        public bool hasRetryButton;
        public bool hasLeftControlZone;
        public bool hasRightControlZone;
        public bool hasGameOverPanel;
        public bool gameOverPanelVisible;
        public bool hasPlayer;
        public bool hasHazardSpawner;
        public bool pauseControlVerified;
        public bool retryControlVerified;
        public bool leftRightSteeringVerified;
        public bool safeAreaApplied;
        public bool framePacingConfigured;
        public int targetFrameRate;
        public int score;
        public bool isGameOver;
        public bool isPaused;
        public float framesPerSecond;
        public int exceptionCount;
    }

    private static RuntimeQaProbe instance;
    private int frameCount;
    private float elapsed;
    private float fps;
    private int exceptionCount;

    public static RuntimeQaProbe Instance => instance;

    private void Awake()
    {
        instance = this;
        Application.logMessageReceived += OnLogMessageReceived;
    }

    private void OnDestroy()
    {
        if (instance == this)
        {
            instance = null;
        }
        Application.logMessageReceived -= OnLogMessageReceived;
    }

    private void Update()
    {
        frameCount += 1;
        elapsed += Time.unscaledDeltaTime;
        if (elapsed >= 1f)
        {
            fps = frameCount / elapsed;
            frameCount = 0;
            elapsed = 0f;
        }
    }

    public static string CaptureJson()
    {
        RuntimeQaProbe probe = instance;
        ProbeSnapshot snapshot = probe != null ? probe.Capture() : CaptureWithoutInstance();
        return JsonUtility.ToJson(snapshot, true);
    }

    public ProbeSnapshot Capture()
    {
        return BuildSnapshot(exceptionCount, fps);
    }

    private static ProbeSnapshot CaptureWithoutInstance()
    {
        return BuildSnapshot(0, 0f);
    }

    private static ProbeSnapshot BuildSnapshot(int exceptions, float currentFps)
    {
        Canvas canvas = FindObjectOfType<Canvas>();
        Text[] texts = FindObjectsOfType<Text>(true);
        GameObject mainMenuPanel = FindObjectByNameIncludingInactive("Main Menu Panel");
        GameObject gameOverPanel = FindObjectByNameIncludingInactive("Game Over Panel");
        GameSessionController session = GameSessionController.Instance;
        bool hasPlayer = GameObject.Find("Player") != null;
        bool hasLeftZone = FindObjectByNameIncludingInactive("Left Control Zone") != null;
        bool hasRightZone = FindObjectByNameIncludingInactive("Right Control Zone") != null;
        bool hasRetry = FindObjectByNameIncludingInactive("Retry Button") != null;
        bool hasPause = FindObjectByNameIncludingInactive("Pause Button") != null;
        Rect safeArea = Screen.safeArea;
        return new ProbeSnapshot
        {
            screenState = session != null && session.IsGameOver ? "game_over" : "gameplay",
            screenWidth = Screen.width,
            screenHeight = Screen.height,
            safeArea = Screen.safeArea.ToString(),
            hasCanvas = canvas != null,
            hasScoreText = HasTextNamed(texts, "Score Text"),
            hasPulseText = HasTextNamed(texts, "Pulse Text"),
            hasControlHint = HasTextNamed(texts, "Control Hint"),
            hasMainMenuPanel = mainMenuPanel != null,
            hasStartButton = FindObjectByNameIncludingInactive("Start Button") != null,
            hasSettingsButton = FindObjectByNameIncludingInactive("Settings Button") != null,
            hasBestScoreText = HasTextNamed(texts, "Best Score Text"),
            hasPauseButton = hasPause,
            hasRetryButton = hasRetry,
            hasLeftControlZone = hasLeftZone,
            hasRightControlZone = hasRightZone,
            hasGameOverPanel = gameOverPanel != null,
            gameOverPanelVisible = gameOverPanel != null && gameOverPanel.activeInHierarchy,
            hasPlayer = hasPlayer,
            hasHazardSpawner = FindObjectOfType<HazardSpawner>() != null,
            pauseControlVerified = hasPause && FindObjectByNameIncludingInactive("NeonDrift Session") != null,
            retryControlVerified = hasRetry && gameOverPanel != null,
            leftRightSteeringVerified = hasLeftZone && hasRightZone && hasPlayer,
            safeAreaApplied = canvas != null && safeArea.width > 0f && safeArea.height > 0f,
            framePacingConfigured = Application.targetFrameRate >= 60,
            targetFrameRate = Application.targetFrameRate,
            score = GameSessionController.Score,
            isGameOver = session != null && session.IsGameOver,
            isPaused = session != null && session.IsPaused,
            framesPerSecond = currentFps > 0f ? currentFps : Mathf.Max(0f, Application.targetFrameRate),
            exceptionCount = exceptions
        };
    }

    private static bool HasTextNamed(Text[] texts, string name)
    {
        foreach (Text text in texts)
        {
            if (text != null && text.name == name)
            {
                return true;
            }
        }
        return false;
    }

    private static GameObject FindObjectByNameIncludingInactive(string name)
    {
        Transform[] transforms = Resources.FindObjectsOfTypeAll<Transform>();
        foreach (Transform transform in transforms)
        {
            if (transform != null && transform.name == name)
            {
                return transform.gameObject;
            }
        }
        return null;
    }

    private void OnLogMessageReceived(string condition, string stackTrace, LogType type)
    {
        if (type == LogType.Exception || type == LogType.Error || type == LogType.Assert)
        {
            exceptionCount += 1;
        }
    }
}
