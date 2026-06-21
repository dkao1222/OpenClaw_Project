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
        public bool hasGameOverPanel;
        public bool gameOverPanelVisible;
        public bool hasPlayer;
        public bool hasHazardSpawner;
        public int score;
        public bool isGameOver;
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
        GameObject gameOverPanel = FindObjectByNameIncludingInactive("Game Over Panel");
        GameSessionController session = GameSessionController.Instance;
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
            hasGameOverPanel = gameOverPanel != null,
            gameOverPanelVisible = gameOverPanel != null && gameOverPanel.activeInHierarchy,
            hasPlayer = GameObject.Find("Player") != null,
            hasHazardSpawner = FindObjectOfType<HazardSpawner>() != null,
            score = GameSessionController.Score,
            isGameOver = session != null && session.IsGameOver,
            framesPerSecond = currentFps,
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
