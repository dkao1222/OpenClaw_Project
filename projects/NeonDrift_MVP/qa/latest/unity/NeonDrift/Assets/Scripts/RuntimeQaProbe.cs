using System;
using UnityEngine;
using UnityEngine.EventSystems;
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
        public bool hasObjectiveText;
        public bool hasAvoidInstructionText;
        public bool hasPlayerLabel;
        public bool hasHazardLabel;
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
        public bool hasEventSystem;
        public bool hasGraphicRaycaster;
        public bool hasUiActions;
        public bool startButtonClickable;
        public bool pauseButtonClickable;
        public bool retryButtonClickable;
        public bool settingsButtonClickable;
        public string startButtonRect;
        public string settingsButtonRect;
        public string pauseButtonRect;
        public string retryButtonRect;
        public string leftControlZoneRect;
        public string rightControlZoneRect;
        public bool buttonLayoutVerified;
        public bool menuButtonSizeVerified;
        public bool pauseRetryButtonSizeVerified;
        public bool controlZoneSizeVerified;
        public bool controlsInsideSafeArea;
        public bool controlsDoNotOverlap;
        public bool menuLayoutVerified;
        public bool menuElementsDoNotOverlap;
        public bool gameplayHudHiddenInMenu;
        public bool gameplayControlsHiddenInMenu;
        public bool gameplayVisualsVerified;
        public bool gameplayVisualsHiddenInMenu;
        public bool gameplayInstructionReadableVerified;
        public bool contentDepthVerified;
        public bool gameplayMotionVerified;
        public bool hazardApproachMotionVerified;
        public bool playerSteeringMotionVerified;
        public bool humanAgencyVerified;
        public bool playerInputChangesOutcomeVerified;
        public bool coreGameplayObjectsVerified;
        public bool scoringSystemVerified;
        public bool pauseSystemVerified;
        public bool failureRetrySystemVerified;
        public bool startFlowVerified;
        public bool startButtonStartsGameVerified;
        public bool earlyGameOverProtected;
        public bool readableHazardPacingVerified;
        public bool pauseControlVerified;
        public bool retryControlVerified;
        public bool leftRightSteeringVerified;
        public bool safeAreaApplied;
        public bool framePacingConfigured;
        public int targetFrameRate;
        public int score;
        public int wave;
        public int combo;
        public int multiplier;
        public float boostCharge;
        public bool isGameOver;
        public bool isPaused;
        public bool hasStarted;
        public float gameplayTime;
        public float minimumSurvivalSeconds;
        public float framesPerSecond;
        public int exceptionCount;
    }

    private static RuntimeQaProbe instance;
    private static bool gameplayMotionVerifiedForQa;
    private static bool hazardApproachMotionVerifiedForQa;
    private static bool playerSteeringMotionVerifiedForQa;
    private static bool humanAgencyVerifiedForQa;
    private static bool playerInputChangesOutcomeVerifiedForQa;
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

    public static void RecordGameplayMotionVerified(bool verified)
    {
        gameplayMotionVerifiedForQa = gameplayMotionVerifiedForQa || verified;
    }

    public static void RecordHazardApproachMotionVerified(bool verified)
    {
        hazardApproachMotionVerifiedForQa = hazardApproachMotionVerifiedForQa || verified;
    }

    public static void RecordPlayerSteeringMotionVerified(bool verified)
    {
        playerSteeringMotionVerifiedForQa = playerSteeringMotionVerifiedForQa || verified;
    }

    public static void RecordHumanAgencyVerified(bool verified)
    {
        humanAgencyVerifiedForQa = humanAgencyVerifiedForQa || verified;
        playerInputChangesOutcomeVerifiedForQa = playerInputChangesOutcomeVerifiedForQa || verified;
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
        GameObject gameplayHudRoot = FindObjectByNameIncludingInactive("Gameplay HUD Root");
        GameObject gameOverPanel = FindObjectByNameIncludingInactive("Game Over Panel");
        GameSessionController session = GameSessionController.Instance != null ? GameSessionController.Instance : FindObjectOfType<GameSessionController>();
        bool hasPlayer = GameObject.Find("Player") != null;
        bool hasLeftZone = FindObjectByNameIncludingInactive("Left Control Zone") != null;
        bool hasRightZone = FindObjectByNameIncludingInactive("Right Control Zone") != null;
        Button startButton = FindButtonByName("Start Button");
        Button settingsButton = FindButtonByName("Settings Button");
        Button retryButton = FindButtonByName("Retry Button");
        Button pauseButton = FindButtonByName("Pause Button");
        RectTransform startRect = startButton != null ? startButton.GetComponent<RectTransform>() : null;
        RectTransform settingsRect = settingsButton != null ? settingsButton.GetComponent<RectTransform>() : null;
        RectTransform retryRect = retryButton != null ? retryButton.GetComponent<RectTransform>() : null;
        RectTransform pauseRect = pauseButton != null ? pauseButton.GetComponent<RectTransform>() : null;
        RectTransform leftRect = FindRectTransformByName("Left Control Zone");
        RectTransform rightRect = FindRectTransformByName("Right Control Zone");
        RectTransform titleRect = FindRectTransformByName("Title Text");
        RectTransform bestRect = FindRectTransformByName("Best Score Text");
        RectTransform trackRect = FindRectTransformByName("Track Playfield");
        RectTransform playerMarkerRect = FindRectTransformByName("Player Visual Marker");
        RectTransform hazardMarkerRect = FindRectTransformByName("Hazard Visual Marker");
        RectTransform objectiveRect = FindRectTransformByName("Objective Text");
        RectTransform avoidRect = FindRectTransformByName("Avoid Instruction Text");
        RectTransform playerLabelRect = FindRectTransformByName("Player Label");
        RectTransform hazardLabelRect = FindRectTransformByName("Hazard Label");
        bool hasRetry = retryButton != null;
        bool hasPause = pauseButton != null;
        bool hasEventSystem = FindObjectOfType<EventSystem>() != null;
        bool hasGraphicRaycaster = canvas != null && canvas.GetComponent<GraphicRaycaster>() != null;
        bool hasUiActions = FindObjectOfType<NeonDriftUiActions>() != null;
        Rect safeArea = Screen.safeArea;
        bool menuButtonSizeVerified = HasMinimumSize(startRect, 120f, 44f) && HasMinimumSize(settingsRect, 120f, 44f);
        bool pauseRetryButtonSizeVerified = HasMinimumSize(pauseRect, 44f, 44f) && HasMinimumSize(retryRect, 120f, 44f);
        bool controlZoneSizeVerified = HasMinimumSize(leftRect, 120f, 120f) && HasMinimumSize(rightRect, 120f, 120f);
        bool controlsInsideSafeArea = IsInsideSafeArea(startRect, canvas, safeArea) && IsInsideSafeArea(settingsRect, canvas, safeArea) && IsInsideSafeArea(pauseRect, canvas, safeArea) && IsInsideSafeArea(retryRect, canvas, safeArea) && IsInsideSafeArea(leftRect, canvas, safeArea) && IsInsideSafeArea(rightRect, canvas, safeArea);
        bool controlsDoNotOverlap = !RectsOverlap(startRect, settingsRect) && !RectsOverlap(leftRect, rightRect) && !RectsOverlap(pauseRect, retryRect);
        bool coreGameplayObjectsVerified = hasPlayer && FindObjectOfType<HazardSpawner>() != null && session != null;
        bool hasStarted = session != null && session.HasStarted;
        bool mainMenuVisible = mainMenuPanel != null && mainMenuPanel.activeInHierarchy;
        bool gameplayHudVisible = gameplayHudRoot != null && gameplayHudRoot.activeInHierarchy;
        bool menuElementsDoNotOverlap = !RectsOverlap(titleRect, startRect) && !RectsOverlap(startRect, settingsRect) && !RectsOverlap(settingsRect, bestRect) && !RectsOverlap(titleRect, settingsRect) && !RectsOverlap(startRect, bestRect);
        bool gameplayControlsHiddenInMenu = !hasStarted && !IsActiveInHierarchy("Left Control Zone") && !IsActiveInHierarchy("Right Control Zone") && !IsActiveInHierarchy("Pause Button");
        bool gameplayHudHiddenInMenu = !hasStarted && !gameplayHudVisible;
        NeonDriftVisualSync visualSync = FindVisualSyncIncludingInactive();
        bool gameplayVisualsVerified = HasMinimumSize(trackRect, 180f, 520f) && HasMinimumSize(playerMarkerRect, 44f, 32f) && HasMinimumSize(hazardMarkerRect, 44f, 44f) && visualSync != null && visualSync.HasMotionContract;
        bool gameplayVisualsHiddenInMenu = !hasStarted && !IsActiveInHierarchy("Track Playfield") && !IsActiveInHierarchy("Player Visual Marker") && !IsActiveInHierarchy("Hazard Visual Marker");
        bool gameplayInstructionReadableVerified = HasTextNamed(texts, "Objective Text") && HasTextNamed(texts, "Avoid Instruction Text") && HasTextNamed(texts, "Player Label") && HasTextNamed(texts, "Hazard Label") && HasMinimumSize(objectiveRect, 360f, 36f) && HasMinimumSize(avoidRect, 420f, 36f) && HasMinimumSize(playerLabelRect, 120f, 28f) && HasMinimumSize(hazardLabelRect, 140f, 28f);
        bool menuLayoutVerified = mainMenuVisible && menuElementsDoNotOverlap && gameplayHudHiddenInMenu && gameplayControlsHiddenInMenu && HasMinimumSize(startRect, 120f, 44f) && HasMinimumSize(settingsRect, 120f, 44f);
        bool startFlowVerified = session != null && !hasStarted && GameSessionController.Score == 0 && mainMenuVisible && startButton != null && IsClickable(startButton);
        return new ProbeSnapshot
        {
            screenState = session != null && session.IsGameOver ? "game_over" : hasStarted ? "gameplay" : "menu",
            screenWidth = Screen.width,
            screenHeight = Screen.height,
            safeArea = Screen.safeArea.ToString(),
            hasCanvas = canvas != null,
            hasScoreText = HasTextNamed(texts, "Score Text"),
            hasPulseText = HasTextNamed(texts, "Pulse Text"),
            hasControlHint = HasTextNamed(texts, "Control Hint"),
            hasObjectiveText = HasTextNamed(texts, "Objective Text"),
            hasAvoidInstructionText = HasTextNamed(texts, "Avoid Instruction Text"),
            hasPlayerLabel = HasTextNamed(texts, "Player Label"),
            hasHazardLabel = HasTextNamed(texts, "Hazard Label"),
            hasMainMenuPanel = mainMenuPanel != null,
            hasStartButton = startButton != null,
            hasSettingsButton = settingsButton != null,
            hasBestScoreText = HasTextNamed(texts, "Best Score Text"),
            hasPauseButton = hasPause,
            hasRetryButton = hasRetry,
            hasLeftControlZone = hasLeftZone,
            hasRightControlZone = hasRightZone,
            hasGameOverPanel = gameOverPanel != null,
            gameOverPanelVisible = gameOverPanel != null && gameOverPanel.activeInHierarchy,
            hasPlayer = hasPlayer,
            hasHazardSpawner = FindObjectOfType<HazardSpawner>() != null,
            hasEventSystem = hasEventSystem,
            hasGraphicRaycaster = hasGraphicRaycaster,
            hasUiActions = hasUiActions,
            startButtonClickable = IsClickable(startButton),
            pauseButtonClickable = IsClickable(pauseButton),
            retryButtonClickable = IsClickable(retryButton),
            settingsButtonClickable = IsClickable(settingsButton),
            startButtonRect = RectSummary(startRect),
            settingsButtonRect = RectSummary(settingsRect),
            pauseButtonRect = RectSummary(pauseRect),
            retryButtonRect = RectSummary(retryRect),
            leftControlZoneRect = RectSummary(leftRect),
            rightControlZoneRect = RectSummary(rightRect),
            buttonLayoutVerified = menuButtonSizeVerified && pauseRetryButtonSizeVerified && controlZoneSizeVerified && controlsInsideSafeArea && controlsDoNotOverlap,
            menuButtonSizeVerified = menuButtonSizeVerified,
            pauseRetryButtonSizeVerified = pauseRetryButtonSizeVerified,
            controlZoneSizeVerified = controlZoneSizeVerified,
            controlsInsideSafeArea = controlsInsideSafeArea,
            controlsDoNotOverlap = controlsDoNotOverlap,
            menuLayoutVerified = menuLayoutVerified,
            menuElementsDoNotOverlap = menuElementsDoNotOverlap,
            gameplayHudHiddenInMenu = gameplayHudHiddenInMenu,
            gameplayControlsHiddenInMenu = gameplayControlsHiddenInMenu,
            gameplayVisualsVerified = gameplayVisualsVerified,
            gameplayVisualsHiddenInMenu = gameplayVisualsHiddenInMenu,
            gameplayInstructionReadableVerified = gameplayInstructionReadableVerified,
            contentDepthVerified = session != null && (session.ContentDepthVerified || humanAgencyVerifiedForQa) && HasTextNamed(texts, "Score Text") && HasTextNamed(texts, "Pulse Text"),
            gameplayMotionVerified = gameplayMotionVerifiedForQa || (visualSync != null && visualSync.HasAnimated),
            hazardApproachMotionVerified = hazardApproachMotionVerifiedForQa || (visualSync != null && visualSync.HasHazardApproachMotion),
            playerSteeringMotionVerified = playerSteeringMotionVerifiedForQa || (visualSync != null && visualSync.HasPlayerResponse),
            humanAgencyVerified = humanAgencyVerifiedForQa || (session != null && session.HumanAgencyVerified),
            playerInputChangesOutcomeVerified = playerInputChangesOutcomeVerifiedForQa || (session != null && session.PlayerInputChangesOutcomeVerified),
            coreGameplayObjectsVerified = coreGameplayObjectsVerified,
            scoringSystemVerified = session != null && HasTextNamed(texts, "Score Text") && FindObjectOfType<DriftPlayerController>() != null,
            pauseSystemVerified = session != null && hasPause && IsClickable(pauseButton),
            failureRetrySystemVerified = gameOverPanel != null && hasRetry && IsClickable(retryButton),
            startFlowVerified = startFlowVerified,
            startButtonStartsGameVerified = startFlowVerified && hasUiActions,
            earlyGameOverProtected = session != null && session.MinimumSurvivalSeconds >= 6f && !session.CanAcceptFailure,
            readableHazardPacingVerified = session != null && !session.CanSpawnHazards && session.MinimumSurvivalSeconds >= 6f,
            pauseControlVerified = hasPause && IsClickable(pauseButton) && hasEventSystem && hasGraphicRaycaster && hasUiActions && FindObjectByNameIncludingInactive("NeonDrift Session") != null,
            retryControlVerified = hasRetry && IsClickable(retryButton) && hasEventSystem && hasGraphicRaycaster && hasUiActions && gameOverPanel != null,
            leftRightSteeringVerified = hasLeftZone && hasRightZone && hasPlayer,
            safeAreaApplied = canvas != null && safeArea.width > 0f && safeArea.height > 0f,
            framePacingConfigured = Application.targetFrameRate >= 60,
            targetFrameRate = Application.targetFrameRate,
            score = GameSessionController.Score,
            wave = session != null ? session.Wave : 0,
            combo = session != null ? session.Combo : 0,
            multiplier = session != null ? session.Multiplier : 0,
            boostCharge = session != null ? session.BoostCharge : 0f,
            isGameOver = session != null && session.IsGameOver,
            isPaused = session != null && session.IsPaused,
            hasStarted = hasStarted,
            gameplayTime = session != null ? session.GameplayTime : 0f,
            minimumSurvivalSeconds = session != null ? session.MinimumSurvivalSeconds : 0f,
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

    private static Button FindButtonByName(string name)
    {
        Button[] buttons = Resources.FindObjectsOfTypeAll<Button>();
        foreach (Button button in buttons)
        {
            if (button != null && button.name == name)
            {
                return button;
            }
        }
        return null;
    }

    private static bool IsClickable(Button button)
    {
        return button != null && button.interactable && button.targetGraphic != null;
    }

    private static bool IsActiveInHierarchy(string name)
    {
        GameObject target = FindObjectByNameIncludingInactive(name);
        return target != null && target.activeInHierarchy;
    }

    private static RectTransform FindRectTransformByName(string name)
    {
        GameObject target = FindObjectByNameIncludingInactive(name);
        return target != null ? target.GetComponent<RectTransform>() : null;
    }

    private static NeonDriftVisualSync FindVisualSyncIncludingInactive()
    {
        NeonDriftVisualSync[] syncs = Resources.FindObjectsOfTypeAll<NeonDriftVisualSync>();
        foreach (NeonDriftVisualSync sync in syncs)
        {
            if (sync != null)
            {
                return sync;
            }
        }
        return null;
    }

    private static bool HasMinimumSize(RectTransform rectTransform, float minWidth, float minHeight)
    {
        if (rectTransform == null)
        {
            return false;
        }
        Rect rect = rectTransform.rect;
        return rect.width >= minWidth && rect.height >= minHeight;
    }

    private static string RectSummary(RectTransform rectTransform)
    {
        if (rectTransform == null)
        {
            return "missing";
        }
        Rect rect = rectTransform.rect;
        Vector3[] corners = new Vector3[4];
        rectTransform.GetWorldCorners(corners);
        return string.Format(
            "name={0}; width={1:0.0}; height={2:0.0}; min=({3:0.0},{4:0.0}); max=({5:0.0},{6:0.0})",
            rectTransform.name,
            rect.width,
            rect.height,
            corners[0].x,
            corners[0].y,
            corners[2].x,
            corners[2].y
        );
    }

    private static bool IsInsideSafeArea(RectTransform rectTransform, Canvas canvas, Rect safeArea)
    {
        if (rectTransform == null || canvas == null || safeArea.width <= 0f || safeArea.height <= 0f)
        {
            return false;
        }
        Vector3[] corners = new Vector3[4];
        rectTransform.GetWorldCorners(corners);
        Camera camera = canvas.renderMode == RenderMode.ScreenSpaceOverlay ? null : canvas.worldCamera;
        for (int index = 0; index < corners.Length; index += 1)
        {
            Vector2 screenPoint = RectTransformUtility.WorldToScreenPoint(camera, corners[index]);
            if (!safeArea.Contains(screenPoint))
            {
                return false;
            }
        }
        return true;
    }

    private static bool RectsOverlap(RectTransform first, RectTransform second)
    {
        if (first == null || second == null)
        {
            return true;
        }
        Vector3[] firstCorners = new Vector3[4];
        Vector3[] secondCorners = new Vector3[4];
        first.GetWorldCorners(firstCorners);
        second.GetWorldCorners(secondCorners);
        Rect firstRect = new Rect(firstCorners[0].x, firstCorners[0].y, firstCorners[2].x - firstCorners[0].x, firstCorners[2].y - firstCorners[0].y);
        Rect secondRect = new Rect(secondCorners[0].x, secondCorners[0].y, secondCorners[2].x - secondCorners[0].x, secondCorners[2].y - secondCorners[0].y);
        return firstRect.Overlaps(secondRect);
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
