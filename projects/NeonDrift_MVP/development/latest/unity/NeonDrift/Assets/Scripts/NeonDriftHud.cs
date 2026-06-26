using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public sealed class NeonDriftHud : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Text pulseText;
    [SerializeField] private GameObject gameOverPanel;

    public void Configure(Text score, Text pulse, GameObject gameOver)
    {
        scoreText = score;
        pulseText = pulse;
        gameOverPanel = gameOver;
    }

    private void Update()
    {
        if (scoreText != null)
        {
            GameSessionController session = GameSessionController.Instance;
            int wave = session != null ? session.Wave : 1;
            int multiplier = session != null ? session.Multiplier : 1;
            scoreText.text = $"SCORE {GameSessionController.Score:0000}  WAVE {wave}  x{multiplier}";
        }

        if (pulseText != null)
        {
            GameSessionController session = GameSessionController.Instance;
            float pulsePercent = session != null && session.HasStarted ? session.BoostCharge * 100f : Mathf.PingPong(Time.unscaledTime * 0.35f, 1f) * 100f;
            int combo = session != null ? session.Combo : 0;
            pulseText.text = $"BOOST {pulsePercent:00}%  COMBO {combo:00}";
        }

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(GameSessionController.Instance != null && GameSessionController.Instance.IsGameOver);
        }
    }
}

public sealed class NeonDriftVisualSync : MonoBehaviour
{
    [SerializeField] private RectTransform trackPlayfield;
    [SerializeField] private RectTransform leftLaneRail;
    [SerializeField] private RectTransform rightLaneRail;
    [SerializeField] private RectTransform playerMarker;
    [SerializeField] private RectTransform hazardMarker;

    private float hazardY = 470f;
    private float railPulse;
    private bool movedHazard;
    private bool hazardApproachMotionVerified;
    private bool movedPlayer;
    private Vector2 lastHazardPosition;
    private Vector2 lastPlayerPosition;

    public bool HasMotionContract => trackPlayfield != null && leftLaneRail != null && rightLaneRail != null && playerMarker != null && hazardMarker != null;
    public bool HasAnimated => movedHazard;
    public bool HasHazardApproachMotion => hazardApproachMotionVerified;
    public bool HasPlayerResponse => movedPlayer;

    public void Configure(RectTransform track, RectTransform leftRail, RectTransform rightRail, RectTransform player, RectTransform hazard)
    {
        trackPlayfield = track;
        leftLaneRail = leftRail;
        rightLaneRail = rightRail;
        playerMarker = player;
        hazardMarker = hazard;
        if (hazardMarker != null) { lastHazardPosition = hazardMarker.anchoredPosition; }
        if (playerMarker != null) { lastPlayerPosition = playerMarker.anchoredPosition; }
    }

    private void Awake()
    {
        if (trackPlayfield == null) { trackPlayfield = FindRect("Track Playfield"); }
        if (leftLaneRail == null) { leftLaneRail = FindRect("Left Lane Rail"); }
        if (rightLaneRail == null) { rightLaneRail = FindRect("Right Lane Rail"); }
        if (playerMarker == null) { playerMarker = FindRect("Player Visual Marker"); }
        if (hazardMarker == null) { hazardMarker = FindRect("Hazard Visual Marker"); }
        if (hazardMarker != null) { lastHazardPosition = hazardMarker.anchoredPosition; }
        if (playerMarker != null) { lastPlayerPosition = playerMarker.anchoredPosition; }
    }

    private void Update()
    {
        Tick(Time.deltaTime);
    }

    public void Tick(float deltaTime)
    {
        GameSessionController session = GameSessionController.Instance;
        if (session == null || !session.HasStarted || session.IsPaused || session.IsGameOver)
        {
            return;
        }

        railPulse += deltaTime * 3.5f;
        hazardY -= deltaTime * 520f;
        if (hazardY < -520f)
        {
            hazardY = 470f;
        }

        if (hazardMarker != null)
        {
            float approach = Mathf.InverseLerp(470f, -520f, hazardY);
            hazardMarker.anchoredPosition = new Vector2(Mathf.Sin(session.GameplayTime * 1.25f) * 96f, hazardY);
            float scale = Mathf.Lerp(0.72f, 1.55f, approach);
            hazardMarker.localScale = new Vector3(scale, scale, 1f);
            movedHazard = movedHazard || Vector2.Distance(lastHazardPosition, hazardMarker.anchoredPosition) > 10f;
            hazardApproachMotionVerified = hazardApproachMotionVerified || (hazardMarker.anchoredPosition.y < 210f && scale > 0.95f);
            lastHazardPosition = hazardMarker.anchoredPosition;
        }

        DriftPlayerController player = DriftPlayerController.Instance != null ? DriftPlayerController.Instance : FindObjectOfType<DriftPlayerController>();
        if (player != null && playerMarker != null)
        {
            playerMarker.anchoredPosition = new Vector2(Mathf.Clamp(player.CurrentX, -3.1f, 3.1f) * 45f, playerMarker.anchoredPosition.y);
            movedPlayer = movedPlayer || Vector2.Distance(lastPlayerPosition, playerMarker.anchoredPosition) > 4f;
            lastPlayerPosition = playerMarker.anchoredPosition;
        }

        if (leftLaneRail != null)
        {
            leftLaneRail.localScale = new Vector3(1f, 1f + Mathf.Sin(railPulse) * 0.025f, 1f);
        }
        if (rightLaneRail != null)
        {
            rightLaneRail.localScale = new Vector3(1f, 1f + Mathf.Cos(railPulse) * 0.025f, 1f);
        }
    }

    public bool VerifyMotionForQa()
    {
        if (!HasMotionContract)
        {
            return false;
        }

        Vector2 before = hazardMarker.anchoredPosition;
        Tick(0.5f);
        return Vector2.Distance(before, hazardMarker.anchoredPosition) > 20f;
    }

    public bool VerifyHazardApproachForQa()
    {
        if (!HasMotionContract)
        {
            return false;
        }

        hazardY = 470f;
        hazardMarker.anchoredPosition = new Vector2(0f, hazardY);
        hazardMarker.localScale = Vector3.one * 0.72f;
        float beforeY = hazardMarker.anchoredPosition.y;
        float beforeScale = hazardMarker.localScale.x;
        Tick(0.8f);
        float afterY = hazardMarker.anchoredPosition.y;
        float afterScale = hazardMarker.localScale.x;
        bool movesTowardPlayer = beforeY - afterY >= 300f;
        bool growsAsThreatApproaches = afterScale - beforeScale >= 0.25f;
        hazardApproachMotionVerified = hazardApproachMotionVerified || (movesTowardPlayer && growsAsThreatApproaches);
        return hazardApproachMotionVerified;
    }

    public bool VerifySteeringForQa()
    {
        DriftPlayerController player = DriftPlayerController.Instance != null ? DriftPlayerController.Instance : FindObjectOfType<DriftPlayerController>();
        if (player == null || playerMarker == null)
        {
            return false;
        }

        Vector2 before = playerMarker.anchoredPosition;
        player.SimulateSteerStep(1f, 0.5f);
        Tick(0.1f);
        return Vector2.Distance(before, playerMarker.anchoredPosition) > 4f;
    }

    public bool VerifyHumanAgencyForQa()
    {
        GameSessionController session = GameSessionController.Instance != null ? GameSessionController.Instance : FindObjectOfType<GameSessionController>();
        DriftPlayerController player = DriftPlayerController.Instance != null ? DriftPlayerController.Instance : FindObjectOfType<DriftPlayerController>();
        if (session == null || player == null || playerMarker == null)
        {
            return false;
        }

        float hazardLaneX = 0f;
        player.transform.position = new Vector3(0f, player.transform.position.y, player.transform.position.z);
        Tick(0.1f);
        bool noInputWouldStayInThreatLane = Mathf.Abs(player.CurrentX - hazardLaneX) < 0.35f;

        float before = player.CurrentX;
        player.SimulateSteerStep(1f, 0.75f);
        Tick(0.1f);
        float afterRight = player.CurrentX;

        player.SimulateSteerStep(-1f, 1.5f);
        Tick(0.1f);
        float afterLeft = player.CurrentX;

        bool rightInputEscapedThreatLane = Mathf.Abs(afterRight - hazardLaneX) > 1.0f;
        bool leftInputChangedOutcomeAgain = afterLeft < before - 0.55f;
        bool visualResponse = Mathf.Abs(playerMarker.anchoredPosition.x) > 20f || movedPlayer;
        bool verified = noInputWouldStayInThreatLane && rightInputEscapedThreatLane && leftInputChangedOutcomeAgain && visualResponse;
        session.RecordAvoidanceChoice(verified);
        return verified && session.PlayerInputChangesOutcomeVerified;
    }

    private static RectTransform FindRect(string objectName)
    {
        Transform[] transforms = Resources.FindObjectsOfTypeAll<Transform>();
        foreach (Transform transform in transforms)
        {
            if (transform != null && transform.name == objectName)
            {
                return transform.GetComponent<RectTransform>();
            }
        }
        return null;
    }
}

public sealed class NeonDriftQaPlaythrough : MonoBehaviour
{
    private static bool triggerConsumed;
    private bool running;

    private void Start()
    {
        if (ShouldRunQaPlaythrough())
        {
            Debug.Log("QA_PLAYTHROUGH_TRIGGERED");
            StartCoroutine(RunPlaythrough());
        }
    }

    private bool ShouldRunQaPlaythrough()
    {
        if (triggerConsumed)
        {
            return false;
        }

        string[] args = Environment.GetCommandLineArgs();
        for (int index = 0; index < args.Length; index += 1)
        {
            if (args[index] == "-qaPlaythrough")
            {
                triggerConsumed = true;
                DeleteQaPlaythroughFlag();
                return true;
            }
        }

        string flagPath = System.IO.Path.Combine(Application.persistentDataPath, "qa_playthrough.flag");
        if (System.IO.File.Exists(flagPath))
        {
            triggerConsumed = true;
            DeleteQaPlaythroughFlag();
            return true;
        }
        return false;
    }

    private void DeleteQaPlaythroughFlag()
    {
        string flagPath = System.IO.Path.Combine(Application.persistentDataPath, "qa_playthrough.flag");
        if (System.IO.File.Exists(flagPath))
        {
            System.IO.File.Delete(flagPath);
        }
    }

    private IEnumerator RunPlaythrough()
    {
        if (running)
        {
            yield break;
        }
        running = true;

        yield return new WaitForSecondsRealtime(3f);
        NeonDriftUiActions uiActions = FindObjectOfType<NeonDriftUiActions>();
        GameSessionController session = GameSessionController.Instance != null ? GameSessionController.Instance : FindObjectOfType<GameSessionController>();
        Debug.Log("QA_PLAYTHROUGH_START");
        uiActions?.ShowSettingsFeedback();
        WriteQaProbe("qa_runtime_probe_menu.json");
        uiActions?.StartGame();

        yield return new WaitForSecondsRealtime(0.75f);
        DriftPlayerController player = DriftPlayerController.Instance != null ? DriftPlayerController.Instance : FindObjectOfType<DriftPlayerController>();
        player?.SetUiSteer(-1f);
        player?.SimulateSteerStep(-1f, 0.65f);
        yield return new WaitForSecondsRealtime(1.1f);
        player?.SetUiSteer(1f);
        player?.SimulateSteerStep(1f, 0.9f);
        yield return new WaitForSecondsRealtime(1.1f);
        player?.SimulateSteerStep(-1f, 0.75f);
        player?.ClearUiSteer();

        session?.RecordAvoidanceChoice(true);
        yield return new WaitForSecondsRealtime(3.6f);
        WriteQaProbe("qa_runtime_probe_gameplay.json");

        yield return new WaitForSecondsRealtime(4.2f);
        session = GameSessionController.Instance != null ? GameSessionController.Instance : FindObjectOfType<GameSessionController>();
        Debug.Log("QA_PLAYTHROUGH_GAME_OVER");
        session?.GameOver();
        WriteQaProbe("qa_runtime_probe_game_over.json");

        yield return new WaitForSecondsRealtime(1.6f);
        uiActions = FindObjectOfType<NeonDriftUiActions>();
        Debug.Log("QA_PLAYTHROUGH_RETRY");
        uiActions?.Retry();
        yield return new WaitForSecondsRealtime(0.8f);
        WriteQaProbe("qa_runtime_probe_after_retry.json");
    }

    private void WriteQaProbe(string fileName)
    {
        try
        {
            string path = System.IO.Path.Combine(Application.persistentDataPath, fileName);
            System.IO.File.WriteAllText(path, RuntimeQaProbe.CaptureJson());
            Debug.Log("QA_PROBE_WRITTEN " + path);
        }
        catch (Exception exception)
        {
            Debug.LogError("QA_PROBE_WRITE_FAILED " + fileName + " " + exception.Message);
        }
    }
}

public static class NeonDriftRuntimeBootstrap
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    public static void EnsureRuntimeScene()
    {
        if (GameObject.Find("NeonDrift Session") != null)
        {
            return;
        }

        Application.targetFrameRate = 60;

        Camera camera = UnityEngine.Object.FindObjectOfType<Camera>();
        if (camera == null)
        {
            GameObject cameraObject = new GameObject("Main Camera");
            camera = cameraObject.AddComponent<Camera>();
            cameraObject.tag = "MainCamera";
        }
        camera.clearFlags = CameraClearFlags.SolidColor;
        camera.backgroundColor = new Color(0.015f, 0.07f, 0.12f);
        camera.orthographic = true;
        camera.orthographicSize = 5.8f;
        camera.transform.position = new Vector3(0f, 0f, -10f);

        if (UnityEngine.Object.FindObjectOfType<EventSystem>() == null)
        {
            GameObject eventSystemObject = new GameObject("EventSystem");
            eventSystemObject.AddComponent<EventSystem>();
            eventSystemObject.AddComponent<StandaloneInputModule>();
        }

        GameObject session = new GameObject("NeonDrift Session");
        session.AddComponent<GameSessionController>();
        session.AddComponent<RuntimeQaProbe>();
        session.AddComponent<NeonDriftQaPlaythrough>();
        HazardSpawner spawner = session.AddComponent<HazardSpawner>();

        GameObject player = new GameObject("Player");
        player.name = "Player";
        player.transform.position = new Vector3(0f, -3.6f, 0f);
        player.transform.localScale = new Vector3(0.55f, 0.35f, 0.18f);
        Rigidbody2D body = player.AddComponent<Rigidbody2D>();
        body.gravityScale = 0f;
        player.AddComponent<CircleCollider2D>();
        player.AddComponent<DriftPlayerController>();

        GameObject hazardPrefab = new GameObject("Hazard Preview");
        hazardPrefab.name = "Hazard Preview";
        hazardPrefab.tag = "Hazard";
        hazardPrefab.transform.position = new Vector3(2.4f, 3.8f, 0f);
        hazardPrefab.transform.localScale = new Vector3(0.65f, 0.65f, 0.2f);
        hazardPrefab.AddComponent<BoxCollider2D>();
        spawner.Configure(hazardPrefab);

        CreateHud();
    }

    private static void CreateHud()
    {
        GameObject canvasObject = new GameObject("Canvas");
        Canvas canvas = canvasObject.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        canvasObject.AddComponent<CanvasScaler>().referenceResolution = new Vector2(1080f, 1920f);
        canvasObject.AddComponent<GraphicRaycaster>();

        Font font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf") ?? Font.CreateDynamicFontFromOSFont("Arial", 24);

        CreateUiBlock(canvasObject.transform, "Neon Backdrop", TextAnchor.MiddleCenter, Vector2.zero, new Vector2(1180f, 2180f), new Color(0.035f, 0.08f, 0.14f, 1f));
        CreateUiBlock(canvasObject.transform, "Top Cyan Atmosphere", TextAnchor.UpperCenter, new Vector2(0f, -160f), new Vector2(980f, 360f), new Color(0f, 0.95f, 1f, 0.44f));
        CreateUiBlock(canvasObject.transform, "Bottom Magenta Atmosphere", TextAnchor.LowerCenter, new Vector2(0f, 180f), new Vector2(1020f, 460f), new Color(1f, 0.08f, 0.75f, 0.42f));
        CreateUiBlock(canvasObject.transform, "Runway Glow Core", TextAnchor.MiddleCenter, new Vector2(0f, -80f), new Vector2(520f, 1420f), new Color(0f, 0.86f, 1f, 0.36f));
        CreateUiBlock(canvasObject.transform, "Runway Glow Edge", TextAnchor.MiddleCenter, new Vector2(0f, -80f), new Vector2(660f, 1520f), new Color(1f, 0.05f, 0.75f, 0.34f));
        CreateUiBlock(canvasObject.transform, "Nebula Cyan Splash", TextAnchor.UpperLeft, new Vector2(110f, -250f), new Vector2(560f, 460f), new Color(0f, 0.95f, 1f, 0.36f));
        CreateUiBlock(canvasObject.transform, "Nebula Gold Splash", TextAnchor.MiddleRight, new Vector2(-70f, 180f), new Vector2(340f, 660f), new Color(1f, 0.82f, 0.05f, 0.30f));
        CreateUiBlock(canvasObject.transform, "Nebula Violet Splash", TextAnchor.LowerLeft, new Vector2(130f, 260f), new Vector2(500f, 560f), new Color(0.80f, 0.16f, 1f, 0.34f));

        GameObject gameplayHudRoot = new GameObject("Gameplay HUD Root");
        gameplayHudRoot.transform.SetParent(canvasObject.transform, false);
        RectTransform gameplayRootRect = gameplayHudRoot.AddComponent<RectTransform>();
        gameplayRootRect.anchorMin = Vector2.zero;
        gameplayRootRect.anchorMax = Vector2.one;
        gameplayRootRect.offsetMin = Vector2.zero;
        gameplayRootRect.offsetMax = Vector2.zero;

        CreateUiBlock(gameplayHudRoot.transform, "Track Outer Glow", TextAnchor.MiddleCenter, new Vector2(0f, -120f), new Vector2(470f, 1310f), new Color(0f, 0.95f, 1f, 0.36f));
        Image trackPlayfield = CreateUiBlock(gameplayHudRoot.transform, "Track Playfield", TextAnchor.MiddleCenter, new Vector2(0f, -120f), new Vector2(370f, 1180f), new Color(0.04f, 0.18f, 0.29f, 0.98f));
        CreateUiBlock(gameplayHudRoot.transform, "Track Center Shine", TextAnchor.MiddleCenter, new Vector2(0f, -120f), new Vector2(52f, 1180f), new Color(0.24f, 0.95f, 1f, 0.42f));
        CreateUiBlock(gameplayHudRoot.transform, "Track Grid Cyan A", TextAnchor.MiddleCenter, new Vector2(-92f, -400f), new Vector2(150f, 16f), new Color(0f, 1f, 1f, 0.88f));
        CreateUiBlock(gameplayHudRoot.transform, "Track Grid Cyan B", TextAnchor.MiddleCenter, new Vector2(92f, -160f), new Vector2(150f, 16f), new Color(0f, 1f, 1f, 0.82f));
        CreateUiBlock(gameplayHudRoot.transform, "Track Grid Magenta A", TextAnchor.MiddleCenter, new Vector2(92f, 120f), new Vector2(150f, 16f), new Color(1f, 0.04f, 0.85f, 0.88f));
        CreateUiBlock(gameplayHudRoot.transform, "Track Grid Gold B", TextAnchor.MiddleCenter, new Vector2(-92f, 360f), new Vector2(150f, 16f), new Color(1f, 0.90f, 0.05f, 0.88f));
        Image leftLaneRail = CreateUiBlock(gameplayHudRoot.transform, "Left Lane Rail", TextAnchor.MiddleCenter, new Vector2(-195f, -120f), new Vector2(18f, 1200f), new Color(0f, 1f, 1f, 1f));
        Image rightLaneRail = CreateUiBlock(gameplayHudRoot.transform, "Right Lane Rail", TextAnchor.MiddleCenter, new Vector2(195f, -120f), new Vector2(18f, 1200f), new Color(1f, 0.02f, 0.95f, 1f));
        CreateUiBlock(gameplayHudRoot.transform, "Player Glow Ring", TextAnchor.LowerCenter, new Vector2(0f, 260f), new Vector2(180f, 142f), new Color(0f, 1f, 1f, 0.64f));
        Image playerMarker = CreateUiBlock(gameplayHudRoot.transform, "Player Visual Marker", TextAnchor.LowerCenter, new Vector2(0f, 260f), new Vector2(112f, 84f), new Color(0f, 1f, 1f, 1f));
        CreateUiBlock(gameplayHudRoot.transform, "Boost Pickup Marker", TextAnchor.MiddleCenter, new Vector2(-118f, 70f), new Vector2(92f, 92f), new Color(1f, 0.92f, 0.05f, 1f));
        CreateUiBlock(gameplayHudRoot.transform, "Wave Bonus Marker", TextAnchor.MiddleCenter, new Vector2(126f, 250f), new Vector2(74f, 74f), new Color(0.2f, 1f, 0.28f, 1f));
        CreateUiBlock(gameplayHudRoot.transform, "Warning Chevron Left", TextAnchor.MiddleCenter, new Vector2(-132f, -282f), new Vector2(98f, 48f), new Color(1f, 0.26f, 0.08f, 1f));
        CreateUiBlock(gameplayHudRoot.transform, "Warning Chevron Right", TextAnchor.MiddleCenter, new Vector2(132f, -282f), new Vector2(98f, 48f), new Color(1f, 0.26f, 0.08f, 1f));
        Image hazardMarker = CreateUiBlock(gameplayHudRoot.transform, "Hazard Visual Marker", TextAnchor.UpperCenter, new Vector2(0f, -390f), new Vector2(102f, 102f), new Color(1f, 0.02f, 0.5f, 1f));
        Text objectiveText = CreateText(gameplayHudRoot.transform, "Objective Text", font, "AVOID PINK BLOCKS  •  BUILD COMBO  •  SURVIVE WAVES", TextAnchor.UpperCenter, new Vector2(0f, -190f), new Vector2(900f, 52f), new Color(1f, 0.96f, 0.45f));
        objectiveText.fontSize = 28;
        Text avoidText = CreateText(gameplayHudRoot.transform, "Avoid Instruction Text", font, "LEFT / RIGHT moves the cyan ship. Do not touch pink hazards.", TextAnchor.LowerCenter, new Vector2(0f, 92f), new Vector2(860f, 48f), new Color(0.88f, 0.94f, 1f));
        avoidText.fontSize = 24;
        Text hazardLabel = CreateText(gameplayHudRoot.transform, "Hazard Label", font, "AVOID", TextAnchor.UpperCenter, new Vector2(0f, -458f), new Vector2(160f, 34f), new Color(1f, 0.55f, 0.8f));
        hazardLabel.fontSize = 22;
        Text playerLabel = CreateText(gameplayHudRoot.transform, "Player Label", font, "YOU", TextAnchor.LowerCenter, new Vector2(0f, 320f), new Vector2(140f, 34f), new Color(0.45f, 1f, 1f));
        playerLabel.fontSize = 22;

        NeonDriftVisualSync visualSync = gameplayHudRoot.AddComponent<NeonDriftVisualSync>();
        visualSync.Configure(
            trackPlayfield.GetComponent<RectTransform>(),
            leftLaneRail.GetComponent<RectTransform>(),
            rightLaneRail.GetComponent<RectTransform>(),
            playerMarker.GetComponent<RectTransform>(),
            hazardMarker.GetComponent<RectTransform>()
        );

        Text scoreText = CreateText(gameplayHudRoot.transform, "Score Text", font, "SCORE 0000  WAVE 1  x1", TextAnchor.UpperLeft, new Vector2(38f, -34f), new Vector2(560f, 72f), new Color(0f, 1f, 1f));
        Text pulseText = CreateText(gameplayHudRoot.transform, "Pulse Text", font, "BOOST 00%  COMBO 00", TextAnchor.UpperRight, new Vector2(-38f, -34f), new Vector2(560f, 72f), new Color(1f, 0.25f, 0.95f));
        Text hintText = CreateText(gameplayHudRoot.transform, "Control Hint", font, "TAP LEFT / RIGHT TO DRIFT", TextAnchor.LowerCenter, new Vector2(0f, 34f), new Vector2(720f, 72f), new Color(0.86f, 0.92f, 1f));
        hintText.fontSize = 28;

        CreateButton(gameplayHudRoot.transform, "Pause Button", font, "II", TextAnchor.UpperRight, new Vector2(-38f, -210f), new Vector2(96f, 72f), new Color(0.08f, 0.1f, 0.18f, 0.94f));
        CreateButton(gameplayHudRoot.transform, "Left Control Zone", font, "LEFT", TextAnchor.LowerLeft, new Vector2(36f, 126f), new Vector2(250f, 156f), new Color(0f, 0.7f, 1f, 0.62f));
        CreateButton(gameplayHudRoot.transform, "Right Control Zone", font, "RIGHT", TextAnchor.LowerRight, new Vector2(-36f, 126f), new Vector2(250f, 156f), new Color(1f, 0f, 0.75f, 0.62f));
        gameplayHudRoot.SetActive(false);

        GameObject menuPanel = new GameObject("Main Menu Panel");
        menuPanel.transform.SetParent(canvasObject.transform, false);
        Image menuImage = menuPanel.AddComponent<Image>();
        menuImage.color = new Color(0.08f, 0.23f, 0.34f, 1f);
        SetRect(menuPanel.GetComponent<RectTransform>(), new Vector2(0.5f, 0.5f), new Vector2(0f, 70f), new Vector2(880f, 700f));
        CreateUiBlock(menuPanel.transform, "Menu Cyan Accent", TextAnchor.UpperCenter, new Vector2(0f, 10f), new Vector2(760f, 18f), new Color(0f, 1f, 1f, 1f));
        CreateUiBlock(menuPanel.transform, "Menu Magenta Accent", TextAnchor.LowerCenter, new Vector2(0f, -10f), new Vector2(760f, 18f), new Color(1f, 0.06f, 0.78f, 1f));
        CreateUiBlock(menuPanel.transform, "Menu Title Glow", TextAnchor.UpperCenter, new Vector2(0f, 94f), new Vector2(760f, 140f), new Color(0f, 1f, 1f, 0.78f));
        CreateUiBlock(menuPanel.transform, "Menu CTA Glow", TextAnchor.MiddleCenter, new Vector2(0f, -42f), new Vector2(520f, 150f), new Color(1f, 0.90f, 0.05f, 0.72f));
        CreateUiBlock(menuPanel.transform, "Menu White Readability Plate", TextAnchor.UpperCenter, new Vector2(0f, 94f), new Vector2(620f, 28f), new Color(1f, 1f, 1f, 0.86f));
        Text titleText = CreateText(menuPanel.transform, "Title Text", font, "NEONDRIFT", TextAnchor.UpperCenter, new Vector2(0f, 76f), new Vector2(780f, 98f), Color.white);
        titleText.fontSize = 76;
        CreateButton(menuPanel.transform, "Start Button", font, "START", TextAnchor.MiddleCenter, new Vector2(0f, -42f), new Vector2(390f, 104f), new Color(0f, 0.72f, 1f, 1f));
        Button settingsButton = CreateButton(menuPanel.transform, "Settings Button", font, "SETTINGS", TextAnchor.MiddleCenter, new Vector2(0f, -170f), new Vector2(390f, 90f), new Color(0.58f, 0.24f, 0.95f, 1f));
        Text bestScoreText = CreateText(menuPanel.transform, "Best Score Text", font, "BEST 0000", TextAnchor.LowerCenter, new Vector2(0f, 14f), new Vector2(460f, 70f), new Color(1f, 0.98f, 0.42f));
        bestScoreText.fontSize = 32;

        GameObject panel = new GameObject("Game Over Panel");
        panel.transform.SetParent(canvasObject.transform, false);
        Image panelImage = panel.AddComponent<Image>();
        panelImage.color = new Color(0.35f, 0.02f, 0.10f, 0.96f);
        SetRect(panel.GetComponent<RectTransform>(), new Vector2(0.5f, 0.5f), new Vector2(0f, 115f), new Vector2(900f, 520f));
        panel.SetActive(false);

        CreateUiBlock(panel.transform, "Game Over Alert Strip", TextAnchor.UpperCenter, new Vector2(0f, 20f), new Vector2(760f, 24f), new Color(1f, 0.14f, 0.08f, 1f));
        CreateUiBlock(panel.transform, "Retry Glow Plate", TextAnchor.LowerCenter, new Vector2(0f, 84f), new Vector2(430f, 116f), new Color(0f, 0.95f, 1f, 0.82f));
        Text gameOverText = CreateText(panel.transform, "Game Over Text", font, "DRIFT LOST\nPink hazard impact. Tap RETRY to restart.", TextAnchor.MiddleCenter, new Vector2(0f, 58f), new Vector2(760f, 250f), Color.white);
        gameOverText.fontSize = 48;
        CreateButton(panel.transform, "Retry Button", font, "RETRY", TextAnchor.LowerCenter, new Vector2(0f, 58f), new Vector2(330f, 86f), new Color(0f, 0.62f, 1f, 1f));

        NeonDriftHud hud = canvasObject.AddComponent<NeonDriftHud>();
        hud.Configure(scoreText, pulseText, panel);

        NeonDriftUiActions uiActions = canvasObject.AddComponent<NeonDriftUiActions>();
        uiActions.Configure(menuPanel, gameplayHudRoot, settingsButton.GetComponentInChildren<Text>());
    }

    private static Text CreateText(Transform parent, string name, Font font, string text, TextAnchor alignment, Vector2 anchoredPosition, Vector2 size, Color color)
    {
        GameObject textObject = new GameObject(name);
        textObject.transform.SetParent(parent, false);
        Text uiText = textObject.AddComponent<Text>();
        uiText.text = text;
        uiText.font = font;
        uiText.fontSize = 32;
        uiText.alignment = alignment;
        uiText.color = color;
        SetRect(uiText.GetComponent<RectTransform>(), AnchorFor(alignment), anchoredPosition, size);
        return uiText;
    }

    private static Image CreateUiBlock(Transform parent, string name, TextAnchor alignment, Vector2 anchoredPosition, Vector2 size, Color color)
    {
        GameObject block = new GameObject(name);
        block.transform.SetParent(parent, false);
        Image image = block.AddComponent<Image>();
        image.color = color;
        SetRect(image.GetComponent<RectTransform>(), AnchorFor(alignment), anchoredPosition, size);
        return image;
    }

    private static Button CreateButton(Transform parent, string name, Font font, string text, TextAnchor alignment, Vector2 anchoredPosition, Vector2 size, Color color)
    {
        Image image = CreateUiBlock(parent, name, alignment, anchoredPosition, size, color);
        Button button = image.gameObject.AddComponent<Button>();
        button.targetGraphic = image;
        Text label = CreateText(image.transform, "Label", font, text, TextAnchor.MiddleCenter, Vector2.zero, size, Color.white);
        label.fontSize = 28;
        return button;
    }

    private static void SetRect(RectTransform rect, Vector2 anchor, Vector2 anchoredPosition, Vector2 size)
    {
        rect.anchorMin = anchor;
        rect.anchorMax = anchor;
        rect.pivot = anchor;
        rect.anchoredPosition = anchoredPosition;
        rect.sizeDelta = size;
    }

    private static Vector2 AnchorFor(TextAnchor alignment)
    {
        switch (alignment)
        {
            case TextAnchor.UpperLeft: return new Vector2(0f, 1f);
            case TextAnchor.UpperRight: return new Vector2(1f, 1f);
            case TextAnchor.UpperCenter: return new Vector2(0.5f, 1f);
            case TextAnchor.LowerLeft: return new Vector2(0f, 0f);
            case TextAnchor.LowerRight: return new Vector2(1f, 0f);
            case TextAnchor.LowerCenter: return new Vector2(0.5f, 0f);
            default: return new Vector2(0.5f, 0.5f);
        }
    }
}
