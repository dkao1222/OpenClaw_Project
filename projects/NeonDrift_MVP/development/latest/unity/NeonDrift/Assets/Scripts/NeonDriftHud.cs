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
            scoreText.text = $"SCORE {GameSessionController.Score:0000}";
        }

        if (pulseText != null)
        {
            float pulsePercent = Mathf.PingPong(Time.unscaledTime * 0.35f, 1f) * 100f;
            pulseText.text = $"PULSE {pulsePercent:00}%";
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
    private bool movedPlayer;
    private Vector2 lastHazardPosition;
    private Vector2 lastPlayerPosition;

    public bool HasMotionContract => trackPlayfield != null && leftLaneRail != null && rightLaneRail != null && playerMarker != null && hazardMarker != null;
    public bool HasAnimated => movedHazard;
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
        hazardY -= deltaTime * 280f;
        if (hazardY < -465f)
        {
            hazardY = 470f;
        }

        if (hazardMarker != null)
        {
            hazardMarker.anchoredPosition = new Vector2(Mathf.Sin(session.GameplayTime * 1.25f) * 72f, hazardY);
            movedHazard = movedHazard || Vector2.Distance(lastHazardPosition, hazardMarker.anchoredPosition) > 10f;
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

public static class NeonDriftRuntimeBootstrap
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    public static void EnsureRuntimeScene()
    {
        if (GameSessionController.Instance != null || GameObject.Find("NeonDrift Session") != null)
        {
            return;
        }

        Application.targetFrameRate = 60;

        Camera camera = Object.FindObjectOfType<Camera>();
        if (camera == null)
        {
            GameObject cameraObject = new GameObject("Main Camera");
            camera = cameraObject.AddComponent<Camera>();
            cameraObject.tag = "MainCamera";
        }
        camera.clearFlags = CameraClearFlags.SolidColor;
        camera.backgroundColor = new Color(0.04f, 0.05f, 0.09f);
        camera.orthographic = true;
        camera.orthographicSize = 5.8f;
        camera.transform.position = new Vector3(0f, 0f, -10f);

        if (Object.FindObjectOfType<EventSystem>() == null)
        {
            GameObject eventSystemObject = new GameObject("EventSystem");
            eventSystemObject.AddComponent<EventSystem>();
            eventSystemObject.AddComponent<StandaloneInputModule>();
        }

        GameObject session = new GameObject("NeonDrift Session");
        session.AddComponent<GameSessionController>();
        session.AddComponent<RuntimeQaProbe>();
        HazardSpawner spawner = session.AddComponent<HazardSpawner>();

        GameObject player = GameObject.CreatePrimitive(PrimitiveType.Cube);
        player.name = "Player";
        player.transform.position = new Vector3(0f, -3.6f, 0f);
        player.transform.localScale = new Vector3(0.55f, 0.35f, 0.18f);
        BoxCollider box = player.GetComponent<BoxCollider>();
        if (box != null) { Object.Destroy(box); }
        Renderer playerRenderer = player.GetComponent<Renderer>();
        if (playerRenderer != null) { playerRenderer.material.color = new Color(0f, 0.95f, 1f); }
        Rigidbody2D body = player.AddComponent<Rigidbody2D>();
        body.gravityScale = 0f;
        player.AddComponent<CircleCollider2D>();
        player.AddComponent<DriftPlayerController>();

        GameObject hazardPrefab = GameObject.CreatePrimitive(PrimitiveType.Cube);
        hazardPrefab.name = "Hazard Preview";
        hazardPrefab.tag = "Hazard";
        hazardPrefab.transform.position = new Vector3(2.4f, 3.8f, 0f);
        hazardPrefab.transform.localScale = new Vector3(0.65f, 0.65f, 0.2f);
        BoxCollider hazardBox = hazardPrefab.GetComponent<BoxCollider>();
        if (hazardBox != null) { Object.Destroy(hazardBox); }
        Renderer hazardRenderer = hazardPrefab.GetComponent<Renderer>();
        if (hazardRenderer != null) { hazardRenderer.material.color = new Color(1f, 0.15f, 0.55f); }
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

        GameObject gameplayHudRoot = new GameObject("Gameplay HUD Root");
        gameplayHudRoot.transform.SetParent(canvasObject.transform, false);
        RectTransform gameplayRootRect = gameplayHudRoot.AddComponent<RectTransform>();
        gameplayRootRect.anchorMin = Vector2.zero;
        gameplayRootRect.anchorMax = Vector2.one;
        gameplayRootRect.offsetMin = Vector2.zero;
        gameplayRootRect.offsetMax = Vector2.zero;

        Image trackPlayfield = CreateUiBlock(gameplayHudRoot.transform, "Track Playfield", TextAnchor.MiddleCenter, new Vector2(0f, -90f), new Vector2(300f, 1180f), new Color(0.02f, 0.04f, 0.08f, 0.58f));
        Image leftLaneRail = CreateUiBlock(gameplayHudRoot.transform, "Left Lane Rail", TextAnchor.MiddleCenter, new Vector2(-155f, -90f), new Vector2(8f, 1180f), new Color(0f, 0.95f, 1f, 0.86f));
        Image rightLaneRail = CreateUiBlock(gameplayHudRoot.transform, "Right Lane Rail", TextAnchor.MiddleCenter, new Vector2(155f, -90f), new Vector2(8f, 1180f), new Color(1f, 0.1f, 0.9f, 0.86f));
        Image playerMarker = CreateUiBlock(gameplayHudRoot.transform, "Player Visual Marker", TextAnchor.LowerCenter, new Vector2(0f, 260f), new Vector2(72f, 54f), new Color(0f, 0.95f, 1f, 0.96f));
        Image hazardMarker = CreateUiBlock(gameplayHudRoot.transform, "Hazard Visual Marker", TextAnchor.UpperCenter, new Vector2(0f, -360f), new Vector2(82f, 82f), new Color(1f, 0.12f, 0.52f, 0.94f));

        NeonDriftVisualSync visualSync = gameplayHudRoot.AddComponent<NeonDriftVisualSync>();
        visualSync.Configure(
            trackPlayfield.GetComponent<RectTransform>(),
            leftLaneRail.GetComponent<RectTransform>(),
            rightLaneRail.GetComponent<RectTransform>(),
            playerMarker.GetComponent<RectTransform>(),
            hazardMarker.GetComponent<RectTransform>()
        );

        Text scoreText = CreateText(gameplayHudRoot.transform, "Score Text", font, "SCORE 0000", TextAnchor.UpperLeft, new Vector2(38f, -34f), new Vector2(420f, 72f), new Color(0f, 0.95f, 1f));
        Text pulseText = CreateText(gameplayHudRoot.transform, "Pulse Text", font, "PULSE 00%", TextAnchor.UpperRight, new Vector2(-38f, -34f), new Vector2(420f, 72f), new Color(1f, 0.25f, 0.9f));
        Text hintText = CreateText(gameplayHudRoot.transform, "Control Hint", font, "TAP LEFT / RIGHT TO DRIFT", TextAnchor.LowerCenter, new Vector2(0f, 34f), new Vector2(720f, 72f), new Color(0.86f, 0.92f, 1f));
        hintText.fontSize = 28;

        CreateButton(gameplayHudRoot.transform, "Pause Button", font, "II", TextAnchor.UpperRight, new Vector2(-38f, -112f), new Vector2(96f, 72f), new Color(0.08f, 0.1f, 0.16f, 0.88f));
        CreateButton(gameplayHudRoot.transform, "Left Control Zone", font, "LEFT", TextAnchor.LowerLeft, new Vector2(36f, 126f), new Vector2(220f, 140f), new Color(0f, 0.55f, 0.85f, 0.24f));
        CreateButton(gameplayHudRoot.transform, "Right Control Zone", font, "RIGHT", TextAnchor.LowerRight, new Vector2(-36f, 126f), new Vector2(220f, 140f), new Color(0.85f, 0f, 0.65f, 0.24f));
        gameplayHudRoot.SetActive(false);

        GameObject menuPanel = new GameObject("Main Menu Panel");
        menuPanel.transform.SetParent(canvasObject.transform, false);
        Image menuImage = menuPanel.AddComponent<Image>();
        menuImage.color = new Color(0f, 0f, 0f, 0.58f);
        SetRect(menuPanel.GetComponent<RectTransform>(), new Vector2(0.5f, 0.5f), new Vector2(0f, 70f), new Vector2(760f, 560f));
        Text titleText = CreateText(menuPanel.transform, "Title Text", font, "NEONDRIFT", TextAnchor.UpperCenter, new Vector2(0f, 48f), new Vector2(680f, 56f), new Color(0f, 0.95f, 1f));
        titleText.fontSize = 42;
        CreateButton(menuPanel.transform, "Start Button", font, "START", TextAnchor.MiddleCenter, new Vector2(0f, -42f), new Vector2(300f, 82f), new Color(0f, 0.55f, 0.85f, 0.86f));
        Button settingsButton = CreateButton(menuPanel.transform, "Settings Button", font, "SETTINGS", TextAnchor.MiddleCenter, new Vector2(0f, -142f), new Vector2(300f, 72f), new Color(0.14f, 0.12f, 0.28f, 0.9f));
        Text bestScoreText = CreateText(menuPanel.transform, "Best Score Text", font, "BEST 0000", TextAnchor.LowerCenter, new Vector2(0f, -20f), new Vector2(420f, 64f), new Color(0.96f, 0.92f, 0.55f));
        bestScoreText.fontSize = 28;

        GameObject panel = new GameObject("Game Over Panel");
        panel.transform.SetParent(canvasObject.transform, false);
        Image panelImage = panel.AddComponent<Image>();
        panelImage.color = new Color(0f, 0f, 0f, 0.72f);
        SetRect(panel.GetComponent<RectTransform>(), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(760f, 360f));
        panel.SetActive(false);

        Text gameOverText = CreateText(panel.transform, "Game Over Text", font, "DRIFT LOST\nTAP TO RETRY", TextAnchor.MiddleCenter, Vector2.zero, new Vector2(720f, 300f), Color.white);
        gameOverText.fontSize = 54;
        CreateButton(panel.transform, "Retry Button", font, "RETRY", TextAnchor.LowerCenter, new Vector2(0f, 38f), new Vector2(260f, 72f), new Color(0f, 0.55f, 0.85f, 0.85f));

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
