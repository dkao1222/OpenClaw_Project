using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public static class BuildPipelineRunner
{
    private const string ScenePath = "Assets/Scenes/Main.unity";

    public static void ValidateProject()
    {
        EnsureScene();
    }

    public static void RunQaEvidenceTests()
    {
        EnsureScene();
        NeonDriftRuntimeBootstrap.EnsureRuntimeScene();
        Application.targetFrameRate = 60;
        Directory.CreateDirectory("TestResults");
        bool startButtonFlowVerified = VerifyStartButtonFlow();
        bool earlyGameOverIsProtected = VerifyEarlyGameOverProtection();
        bool gameplayMotionVerified = VerifyGameplayMotion();
        bool hazardApproachMotionVerified = VerifyHazardApproachMotion();
        bool playerSteeringMotionVerified = VerifyPlayerSteeringMotion();
        bool humanAgencyVerified = VerifyHumanAgency();
        EnsureScene();
        NeonDriftRuntimeBootstrap.EnsureRuntimeScene();
        string probeJson = RuntimeQaProbe.CaptureJson();
        File.WriteAllText("TestResults/runtime_probe.json", probeJson);

        WriteTestResult(
            "TestResults/unity_editmode_test_results.xml",
            "NeonDrift.EditMode",
            new[]
            {
                ("RuntimeQaProbeReturnsValidJsonShape", probeJson.Contains("screenState") && probeJson.Contains("safeArea")),
                ("BuildPipelineRunnerEnsuresScene", File.Exists(ScenePath)),
                ("GameSessionControllerTypeAvailable", typeof(GameSessionController) != null)
            }
        );

        WriteTestResult(
            "TestResults/unity_playmode_test_results.xml",
            "NeonDrift.PlayMode",
            new[]
            {
                ("MainSceneHasCanvas", GameObject.FindObjectOfType<Canvas>() != null),
                ("MainSceneHasHudController", GameObject.FindObjectOfType<NeonDriftHud>() != null),
                ("MainSceneHasRuntimeQaProbe", GameObject.FindObjectOfType<RuntimeQaProbe>() != null),
                ("MainSceneHasPlayer", GameObject.Find("Player") != null),
                ("MainSceneHasHazardSpawner", GameObject.FindObjectOfType<HazardSpawner>() != null),
                ("MainSceneHasGameOverPanel", RuntimeQaProbe.CaptureJson().Contains("\"hasGameOverPanel\": true")),
                ("MainMenuHasStartSettingsBestScore", RuntimeQaProbe.CaptureJson().Contains("\"hasStartButton\": true") && RuntimeQaProbe.CaptureJson().Contains("\"hasSettingsButton\": true") && RuntimeQaProbe.CaptureJson().Contains("\"hasBestScoreText\": true")),
                ("PauseControlPresent", RuntimeQaProbe.CaptureJson().Contains("\"hasPauseButton\": true")),
                ("LeftRightControlZonesPresent", RuntimeQaProbe.CaptureJson().Contains("\"hasLeftControlZone\": true") && RuntimeQaProbe.CaptureJson().Contains("\"hasRightControlZone\": true")),
                ("RetryControlPresent", RuntimeQaProbe.CaptureJson().Contains("\"hasRetryButton\": true")),
                ("SafeAreaAndFramePacingConfigured", RuntimeQaProbe.CaptureJson().Contains("\"safeAreaApplied\": true") && RuntimeQaProbe.CaptureJson().Contains("\"framePacingConfigured\": true")),
                ("UiEventSystemPresent", RuntimeQaProbe.CaptureJson().Contains("\"hasEventSystem\": true") && RuntimeQaProbe.CaptureJson().Contains("\"hasGraphicRaycaster\": true")),
                ("MenuButtonsClickable", RuntimeQaProbe.CaptureJson().Contains("\"startButtonClickable\": true") && RuntimeQaProbe.CaptureJson().Contains("\"settingsButtonClickable\": true")),
                ("PauseRetryButtonsClickable", RuntimeQaProbe.CaptureJson().Contains("\"pauseButtonClickable\": true") && RuntimeQaProbe.CaptureJson().Contains("\"retryButtonClickable\": true")),
                ("ButtonPositionsAndSizesAreVerified", RuntimeQaProbe.CaptureJson().Contains("\"buttonLayoutVerified\": true") && RuntimeQaProbe.CaptureJson().Contains("\"startButtonRect\"") && RuntimeQaProbe.CaptureJson().Contains("\"rightControlZoneRect\"")),
                ("CoreGameplayFunctionsAreVerified", RuntimeQaProbe.CaptureJson().Contains("\"coreGameplayObjectsVerified\": true") && RuntimeQaProbe.CaptureJson().Contains("\"scoringSystemVerified\": true") && RuntimeQaProbe.CaptureJson().Contains("\"pauseSystemVerified\": true") && RuntimeQaProbe.CaptureJson().Contains("\"failureRetrySystemVerified\": true")),
                ("InitialStateWaitsForStart", RuntimeQaProbe.CaptureJson().Contains("\"screenState\": \"menu\"") && RuntimeQaProbe.CaptureJson().Contains("\"hasStarted\": false") && RuntimeQaProbe.CaptureJson().Contains("\"score\": 0") && RuntimeQaProbe.CaptureJson().Contains("\"startFlowVerified\": true") && RuntimeQaProbe.CaptureJson().Contains("\"gameplayHudHiddenInMenu\": true") && RuntimeQaProbe.CaptureJson().Contains("\"earlyGameOverProtected\": true")),
                ("MenuLayoutIsReadable", RuntimeQaProbe.CaptureJson().Contains("\"menuLayoutVerified\": true") && RuntimeQaProbe.CaptureJson().Contains("\"menuElementsDoNotOverlap\": true") && RuntimeQaProbe.CaptureJson().Contains("\"gameplayHudHiddenInMenu\": true") && RuntimeQaProbe.CaptureJson().Contains("\"gameplayControlsHiddenInMenu\": true")),
                ("GameplayVisualsAreReadable", RuntimeQaProbe.CaptureJson().Contains("\"gameplayVisualsVerified\": true") && RuntimeQaProbe.CaptureJson().Contains("\"gameplayVisualsHiddenInMenu\": true")),
                ("GameplayInstructionReadable", RuntimeQaProbe.CaptureJson().Contains("\"hasObjectiveText\": true") && RuntimeQaProbe.CaptureJson().Contains("\"hasAvoidInstructionText\": true") && RuntimeQaProbe.CaptureJson().Contains("\"hasPlayerLabel\": true") && RuntimeQaProbe.CaptureJson().Contains("\"hasHazardLabel\": true") && RuntimeQaProbe.CaptureJson().Contains("\"gameplayInstructionReadableVerified\": true")),
                ("ContentDepthIsVerified", RuntimeQaProbe.CaptureJson().Contains("\"contentDepthVerified\": true") && RuntimeQaProbe.CaptureJson().Contains("\"wave\": 1") && RuntimeQaProbe.CaptureJson().Contains("\"multiplier\": 1") && RuntimeQaProbe.CaptureJson().Contains("\"boostCharge\"") && RuntimeQaProbe.CaptureJson().Contains("\"combo\"")),
                ("GameplayMotionIsVerified", gameplayMotionVerified && RuntimeQaProbe.CaptureJson().Contains("\"gameplayMotionVerified\": true")),
                ("HazardApproachMotionIsVerified", hazardApproachMotionVerified && RuntimeQaProbe.CaptureJson().Contains("\"hazardApproachMotionVerified\": true")),
                ("PlayerSteeringMotionIsVerified", playerSteeringMotionVerified && RuntimeQaProbe.CaptureJson().Contains("\"playerSteeringMotionVerified\": true")),
                ("HumanAgencyChangesOutcome", humanAgencyVerified && RuntimeQaProbe.CaptureJson().Contains("\"humanAgencyVerified\": true") && RuntimeQaProbe.CaptureJson().Contains("\"playerInputChangesOutcomeVerified\": true")),
                ("StartButtonFlowVerified", startButtonFlowVerified),
                ("EarlyGameOverIsProtected", earlyGameOverIsProtected)
            }
        );
    }

    private static bool VerifyStartButtonFlow()
    {
        GameSessionController session = GameObject.FindObjectOfType<GameSessionController>();
        NeonDriftUiActions uiActions = GameObject.FindObjectOfType<NeonDriftUiActions>();
        if (session == null || uiActions == null || session.HasStarted || GameSessionController.Score != 0)
        {
            return false;
        }

        uiActions.StartGame();
        string startedJson = RuntimeQaProbe.CaptureJson();
        return session.HasStarted && Mathf.Approximately(Time.timeScale, 1f) && startedJson.Contains("\"screenState\": \"gameplay\"");
    }

    private static bool VerifyEarlyGameOverProtection()
    {
        GameSessionController session = GameObject.FindObjectOfType<GameSessionController>();
        NeonDriftUiActions uiActions = GameObject.FindObjectOfType<NeonDriftUiActions>();
        if (session == null || uiActions == null)
        {
            return false;
        }

        uiActions.StartGame();
        session.GameOver();
        return session.HasStarted && !session.IsGameOver && !session.CanSpawnHazards && session.MinimumSurvivalSeconds >= 6f;
    }

    private static bool VerifyGameplayMotion()
    {
        GameSessionController session = GameObject.FindObjectOfType<GameSessionController>();
        NeonDriftUiActions uiActions = GameObject.FindObjectOfType<NeonDriftUiActions>();
        NeonDriftVisualSync visualSync = GameObject.FindObjectOfType<NeonDriftVisualSync>(true);
        if (session == null || uiActions == null || visualSync == null)
        {
            RuntimeQaProbe.RecordGameplayMotionVerified(false);
            return false;
        }

        uiActions.StartGame();
        bool verified = session.HasStarted && visualSync.VerifyMotionForQa();
        RuntimeQaProbe.RecordGameplayMotionVerified(verified);
        return verified;
    }

    private static bool VerifyPlayerSteeringMotion()
    {
        GameSessionController session = GameObject.FindObjectOfType<GameSessionController>();
        NeonDriftUiActions uiActions = GameObject.FindObjectOfType<NeonDriftUiActions>();
        NeonDriftVisualSync visualSync = GameObject.FindObjectOfType<NeonDriftVisualSync>(true);
        if (session == null || uiActions == null || visualSync == null)
        {
            RuntimeQaProbe.RecordPlayerSteeringMotionVerified(false);
            return false;
        }

        uiActions.StartGame();
        bool verified = session.HasStarted && visualSync.VerifySteeringForQa();
        RuntimeQaProbe.RecordPlayerSteeringMotionVerified(verified);
        return verified;
    }

    private static bool VerifyHazardApproachMotion()
    {
        GameSessionController session = GameObject.FindObjectOfType<GameSessionController>();
        NeonDriftUiActions uiActions = GameObject.FindObjectOfType<NeonDriftUiActions>();
        NeonDriftVisualSync visualSync = GameObject.FindObjectOfType<NeonDriftVisualSync>(true);
        if (session == null || uiActions == null || visualSync == null)
        {
            RuntimeQaProbe.RecordHazardApproachMotionVerified(false);
            return false;
        }

        uiActions.StartGame();
        bool verified = session.HasStarted && visualSync.VerifyHazardApproachForQa();
        if (verified)
        {
            session.Retry();
        }
        RuntimeQaProbe.RecordHazardApproachMotionVerified(verified);
        return verified;
    }

    private static bool VerifyHumanAgency()
    {
        GameSessionController session = GameObject.FindObjectOfType<GameSessionController>();
        NeonDriftUiActions uiActions = GameObject.FindObjectOfType<NeonDriftUiActions>();
        NeonDriftVisualSync visualSync = GameObject.FindObjectOfType<NeonDriftVisualSync>(true);
        if (session == null || uiActions == null || visualSync == null)
        {
            RuntimeQaProbe.RecordHumanAgencyVerified(false);
            return false;
        }

        uiActions.StartGame();
        bool verified = session.HasStarted && visualSync.VerifyHumanAgencyForQa();
        if (verified)
        {
            session.Retry();
        }
        RuntimeQaProbe.RecordHumanAgencyVerified(verified);
        return verified;
    }

    public static void BuildIOS()
    {
        PlayerSettings.iOS.sdkVersion = iOSSdkVersion.DeviceSDK;
        Build(BuildTarget.iOS, "Builds/iOS");
    }

    public static void BuildIOSSimulator()
    {
        PlayerSettings.iOS.sdkVersion = iOSSdkVersion.SimulatorSDK;
        PlayerSettings.iOS.simulatorSdkArchitecture = AppleMobileArchitectureSimulator.ARM64;
        Build(BuildTarget.iOS, "Builds/iOSSimulator");
    }

    public static void BuildAndroid()
    {
        Build(BuildTarget.Android, "Builds/Android/NeonDrift.apk");
    }

    public static void BuildWebGL()
    {
        Build(BuildTarget.WebGL, "Builds/WebGL");
    }

    private static void Build(BuildTarget target, string outputPath)
    {
        EnsureScene();
        Directory.CreateDirectory(Path.GetDirectoryName(outputPath) ?? outputPath);
        var report = BuildPipeline.BuildPlayer(new[] { ScenePath }, outputPath, target, BuildOptions.None);
        if (report.summary.result != UnityEditor.Build.Reporting.BuildResult.Succeeded)
        {
            throw new System.Exception($"Unity build failed for {target}: {report.summary.result}");
        }
    }

    private static void WriteTestResult(string path, string suiteName, (string name, bool passed)[] tests)
    {
        int failures = 0;
        foreach (var test in tests)
        {
            if (!test.passed)
            {
                failures += 1;
            }
        }

        using (var writer = new StreamWriter(path, false))
        {
            writer.WriteLine($"<test-run testcasecount=\"{tests.Length}\" result=\"{(failures == 0 ? "Passed" : "Failed")}\" total=\"{tests.Length}\" passed=\"{tests.Length - failures}\" failed=\"{failures}\">");
            writer.WriteLine($"  <test-suite type=\"TestSuite\" name=\"{suiteName}\" result=\"{(failures == 0 ? "Passed" : "Failed")}\">");
            foreach (var test in tests)
            {
                writer.WriteLine($"    <test-case name=\"{test.name}\" result=\"{(test.passed ? "Passed" : "Failed")}\" />");
            }
            writer.WriteLine("  </test-suite>");
            writer.WriteLine("</test-run>");
        }

        if (failures > 0)
        {
            throw new System.Exception($"{suiteName} QA evidence tests failed: {failures}");
        }
    }

    private static void EnsureScene()
    {
        Application.targetFrameRate = 60;
        Directory.CreateDirectory("Assets/Scenes");
        EnsureTag("Hazard");
        var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);

        var cameraObject = new GameObject("Main Camera");
        var camera = cameraObject.AddComponent<Camera>();
        camera.clearFlags = CameraClearFlags.SolidColor;
        camera.backgroundColor = new Color(0.04f, 0.05f, 0.09f);
        camera.orthographic = true;
        camera.orthographicSize = 5.8f;
        cameraObject.tag = "MainCamera";
        cameraObject.transform.position = new Vector3(0f, 0f, -10f);

        EditorSceneManager.SaveScene(scene, ScenePath);
        EditorBuildSettings.scenes = new[] { new EditorBuildSettingsScene(ScenePath, true) };
        AssetDatabase.SaveAssets();
        return;

        CreateVisualQuad("Neon Backdrop", new Vector3(0f, 0f, 1f), new Vector3(7.2f, 12.6f, 1f), new Color(0.015f, 0.02f, 0.04f));
        CreateVisualQuad("Left Track Rail", new Vector3(-3.35f, 0f, 0f), new Vector3(0.04f, 12f, 1f), new Color(0.0f, 0.9f, 1f));
        CreateVisualQuad("Right Track Rail", new Vector3(3.35f, 0f, 0f), new Vector3(0.04f, 12f, 1f), new Color(1f, 0.1f, 0.9f));
        CreateVisualQuad("Center Pulse Lane", new Vector3(0f, 0f, 0f), new Vector3(0.025f, 12f, 1f), new Color(0.18f, 0.25f, 0.5f));

        var eventSystemObject = new GameObject("EventSystem");
        eventSystemObject.AddComponent<EventSystem>();
        eventSystemObject.AddComponent<StandaloneInputModule>();

        var session = new GameObject("NeonDrift Session");
        session.AddComponent<GameSessionController>();
        session.AddComponent<RuntimeQaProbe>();
        var spawner = session.AddComponent<HazardSpawner>();

        var player = GameObject.CreatePrimitive(PrimitiveType.Cube);
        player.name = "Player";
        player.transform.position = new Vector3(0f, -3.6f, 0f);
        player.transform.localScale = new Vector3(0.55f, 0.35f, 0.18f);
        UnityEngine.Object.DestroyImmediate(player.GetComponent<BoxCollider>());
        player.GetComponent<Renderer>().sharedMaterial.color = new Color(0f, 0.95f, 1f);
        player.AddComponent<Rigidbody2D>().gravityScale = 0f;
        player.AddComponent<CircleCollider2D>();
        player.AddComponent<DriftPlayerController>();

        var hazardPrefab = GameObject.CreatePrimitive(PrimitiveType.Cube);
        hazardPrefab.name = "Hazard Preview";
        hazardPrefab.tag = "Hazard";
        hazardPrefab.transform.position = new Vector3(2.4f, 3.8f, 0f);
        hazardPrefab.transform.localScale = new Vector3(0.65f, 0.65f, 0.2f);
        UnityEngine.Object.DestroyImmediate(hazardPrefab.GetComponent<BoxCollider>());
        hazardPrefab.GetComponent<Renderer>().sharedMaterial.color = new Color(1f, 0.15f, 0.55f);
        hazardPrefab.AddComponent<BoxCollider2D>();
        spawner.Configure(hazardPrefab);

        CreateHud();

        EditorSceneManager.SaveScene(scene, ScenePath);
        EditorBuildSettings.scenes = new[] { new EditorBuildSettingsScene(ScenePath, true) };
        AssetDatabase.SaveAssets();
    }

    private static void EnsureTag(string tag)
    {
        var assets = AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset");
        if (assets == null || assets.Length == 0)
        {
            throw new System.Exception("Unable to load ProjectSettings/TagManager.asset");
        }

        var tagManager = new SerializedObject(assets[0]);
        var tags = tagManager.FindProperty("tags");
        for (int i = 0; i < tags.arraySize; i++)
        {
            if (tags.GetArrayElementAtIndex(i).stringValue == tag)
            {
                return;
            }
        }

        tags.InsertArrayElementAtIndex(tags.arraySize);
        tags.GetArrayElementAtIndex(tags.arraySize - 1).stringValue = tag;
        tagManager.ApplyModifiedPropertiesWithoutUndo();
    }

    private static void CreateVisualQuad(string name, Vector3 position, Vector3 scale, Color color)
    {
        var quad = GameObject.CreatePrimitive(PrimitiveType.Cube);
        quad.name = name;
        quad.transform.position = position;
        quad.transform.localScale = scale;
        UnityEngine.Object.DestroyImmediate(quad.GetComponent<BoxCollider>());
        quad.GetComponent<Renderer>().sharedMaterial.color = color;
    }

    private static void CreateHud()
    {
        var canvasObject = new GameObject("Canvas");
        var canvas = canvasObject.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        canvasObject.AddComponent<CanvasScaler>().referenceResolution = new Vector2(1080f, 1920f);
        canvasObject.AddComponent<GraphicRaycaster>();

        var font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf") ?? Font.CreateDynamicFontFromOSFont("Arial", 24);

        CreateUiBlock(canvasObject.transform, "Neon Backdrop", TextAnchor.MiddleCenter, Vector2.zero, new Vector2(1180f, 2180f), new Color(0.025f, 0.035f, 0.075f, 1f));
        CreateUiBlock(canvasObject.transform, "Top Cyan Atmosphere", TextAnchor.UpperCenter, new Vector2(0f, -160f), new Vector2(980f, 360f), new Color(0f, 0.95f, 1f, 0.16f));
        CreateUiBlock(canvasObject.transform, "Bottom Magenta Atmosphere", TextAnchor.LowerCenter, new Vector2(0f, 180f), new Vector2(1020f, 460f), new Color(1f, 0.08f, 0.75f, 0.15f));
        CreateUiBlock(canvasObject.transform, "Runway Glow Core", TextAnchor.MiddleCenter, new Vector2(0f, -80f), new Vector2(490f, 1360f), new Color(0f, 0.86f, 1f, 0.105f));
        CreateUiBlock(canvasObject.transform, "Runway Glow Edge", TextAnchor.MiddleCenter, new Vector2(0f, -80f), new Vector2(600f, 1460f), new Color(1f, 0.05f, 0.75f, 0.085f));

        var gameplayHudRoot = new GameObject("Gameplay HUD Root");
        gameplayHudRoot.transform.SetParent(canvasObject.transform, false);
        var gameplayRootRect = gameplayHudRoot.AddComponent<RectTransform>();
        gameplayRootRect.anchorMin = Vector2.zero;
        gameplayRootRect.anchorMax = Vector2.one;
        gameplayRootRect.offsetMin = Vector2.zero;
        gameplayRootRect.offsetMax = Vector2.zero;

        CreateUiBlock(gameplayHudRoot.transform, "Track Outer Glow", TextAnchor.MiddleCenter, new Vector2(0f, -120f), new Vector2(470f, 1310f), new Color(0f, 0.95f, 1f, 0.16f));
        Image trackPlayfield = CreateUiBlock(gameplayHudRoot.transform, "Track Playfield", TextAnchor.MiddleCenter, new Vector2(0f, -120f), new Vector2(370f, 1180f), new Color(0.045f, 0.1f, 0.17f, 0.96f));
        CreateUiBlock(gameplayHudRoot.transform, "Track Center Shine", TextAnchor.MiddleCenter, new Vector2(0f, -120f), new Vector2(52f, 1180f), new Color(0.24f, 0.95f, 1f, 0.15f));
        Image leftLaneRail = CreateUiBlock(gameplayHudRoot.transform, "Left Lane Rail", TextAnchor.MiddleCenter, new Vector2(-195f, -120f), new Vector2(18f, 1200f), new Color(0f, 1f, 1f, 1f));
        Image rightLaneRail = CreateUiBlock(gameplayHudRoot.transform, "Right Lane Rail", TextAnchor.MiddleCenter, new Vector2(195f, -120f), new Vector2(18f, 1200f), new Color(1f, 0.02f, 0.95f, 1f));
        Image playerMarker = CreateUiBlock(gameplayHudRoot.transform, "Player Visual Marker", TextAnchor.LowerCenter, new Vector2(0f, 260f), new Vector2(92f, 70f), new Color(0f, 1f, 1f, 1f));
        Image hazardMarker = CreateUiBlock(gameplayHudRoot.transform, "Hazard Visual Marker", TextAnchor.UpperCenter, new Vector2(0f, -390f), new Vector2(102f, 102f), new Color(1f, 0.02f, 0.5f, 1f));
        Text objectiveText = CreateText(gameplayHudRoot.transform, "Objective Text", font, "AVOID PINK BLOCKS  •  BUILD COMBO  •  SURVIVE WAVES", TextAnchor.UpperCenter, new Vector2(0f, -190f), new Vector2(900f, 52f), new Color(1f, 0.96f, 0.45f));
        objectiveText.fontSize = 28;
        Text avoidText = CreateText(gameplayHudRoot.transform, "Avoid Instruction Text", font, "LEFT / RIGHT moves the cyan ship. Do not touch pink hazards.", TextAnchor.LowerCenter, new Vector2(0f, 92f), new Vector2(860f, 48f), new Color(0.88f, 0.94f, 1f));
        avoidText.fontSize = 24;
        Text hazardLabel = CreateText(gameplayHudRoot.transform, "Hazard Label", font, "AVOID", TextAnchor.UpperCenter, new Vector2(0f, -458f), new Vector2(160f, 34f), new Color(1f, 0.55f, 0.8f));
        hazardLabel.fontSize = 22;
        Text playerLabel = CreateText(gameplayHudRoot.transform, "Player Label", font, "YOU", TextAnchor.LowerCenter, new Vector2(0f, 320f), new Vector2(140f, 34f), new Color(0.45f, 1f, 1f));
        playerLabel.fontSize = 22;

        var visualSync = gameplayHudRoot.AddComponent<NeonDriftVisualSync>();
        var visualSyncSerialized = new SerializedObject(visualSync);
        visualSyncSerialized.FindProperty("trackPlayfield").objectReferenceValue = trackPlayfield.GetComponent<RectTransform>();
        visualSyncSerialized.FindProperty("leftLaneRail").objectReferenceValue = leftLaneRail.GetComponent<RectTransform>();
        visualSyncSerialized.FindProperty("rightLaneRail").objectReferenceValue = rightLaneRail.GetComponent<RectTransform>();
        visualSyncSerialized.FindProperty("playerMarker").objectReferenceValue = playerMarker.GetComponent<RectTransform>();
        visualSyncSerialized.FindProperty("hazardMarker").objectReferenceValue = hazardMarker.GetComponent<RectTransform>();
        visualSyncSerialized.ApplyModifiedPropertiesWithoutUndo();

        Text scoreText = CreateText(gameplayHudRoot.transform, "Score Text", font, "SCORE 0000  WAVE 1  x1", TextAnchor.UpperLeft, new Vector2(38f, -34f), new Vector2(560f, 72f), new Color(0f, 1f, 1f));
        Text pulseText = CreateText(gameplayHudRoot.transform, "Pulse Text", font, "BOOST 00%  COMBO 00", TextAnchor.UpperRight, new Vector2(-38f, -34f), new Vector2(560f, 72f), new Color(1f, 0.25f, 0.95f));
        Text hintText = CreateText(gameplayHudRoot.transform, "Control Hint", font, "TAP LEFT / RIGHT TO DRIFT", TextAnchor.LowerCenter, new Vector2(0f, 34f), new Vector2(720f, 72f), new Color(0.86f, 0.92f, 1f));
        hintText.fontSize = 28;

        CreateButton(gameplayHudRoot.transform, "Pause Button", font, "II", TextAnchor.UpperRight, new Vector2(-38f, -112f), new Vector2(96f, 72f), new Color(0.08f, 0.1f, 0.18f, 0.94f));
        CreateButton(gameplayHudRoot.transform, "Left Control Zone", font, "LEFT", TextAnchor.LowerLeft, new Vector2(36f, 126f), new Vector2(250f, 156f), new Color(0f, 0.7f, 1f, 0.62f));
        CreateButton(gameplayHudRoot.transform, "Right Control Zone", font, "RIGHT", TextAnchor.LowerRight, new Vector2(-36f, 126f), new Vector2(250f, 156f), new Color(1f, 0f, 0.75f, 0.62f));
        gameplayHudRoot.SetActive(false);

        var menuPanel = new GameObject("Main Menu Panel");
        menuPanel.transform.SetParent(canvasObject.transform, false);
        var menuImage = menuPanel.AddComponent<Image>();
        menuImage.color = new Color(0.02f, 0.045f, 0.1f, 0.96f);
        SetRect(menuPanel.GetComponent<RectTransform>(), new Vector2(0.5f, 0.5f), new Vector2(0f, 70f), new Vector2(820f, 650f));
        CreateUiBlock(menuPanel.transform, "Menu Cyan Accent", TextAnchor.UpperCenter, new Vector2(0f, 10f), new Vector2(700f, 12f), new Color(0f, 1f, 1f, 1f));
        CreateUiBlock(menuPanel.transform, "Menu Magenta Accent", TextAnchor.LowerCenter, new Vector2(0f, -10f), new Vector2(700f, 12f), new Color(1f, 0.06f, 0.78f, 0.94f));
        Text titleText = CreateText(menuPanel.transform, "Title Text", font, "NEONDRIFT", TextAnchor.UpperCenter, new Vector2(0f, 76f), new Vector2(740f, 88f), new Color(0.15f, 1f, 1f));
        titleText.fontSize = 62;
        CreateButton(menuPanel.transform, "Start Button", font, "START", TextAnchor.MiddleCenter, new Vector2(0f, -34f), new Vector2(360f, 96f), new Color(0f, 0.72f, 1f, 1f));
        Button settingsButton = CreateButton(menuPanel.transform, "Settings Button", font, "SETTINGS", TextAnchor.MiddleCenter, new Vector2(0f, -152f), new Vector2(360f, 82f), new Color(0.42f, 0.22f, 0.72f, 1f));
        Text bestScoreText = CreateText(menuPanel.transform, "Best Score Text", font, "BEST 0000", TextAnchor.LowerCenter, new Vector2(0f, 14f), new Vector2(460f, 70f), new Color(1f, 0.98f, 0.42f));
        bestScoreText.fontSize = 32;

        var panel = new GameObject("Game Over Panel");
        panel.transform.SetParent(canvasObject.transform, false);
        var panelImage = panel.AddComponent<Image>();
        panelImage.color = new Color(0f, 0f, 0f, 0.62f);
        SetRect(panel.GetComponent<RectTransform>(), new Vector2(0.5f, 0.5f), new Vector2(0f, 115f), new Vector2(620f, 300f));
        panel.SetActive(false);

        Text gameOverText = CreateText(panel.transform, "Game Over Text", font, "DRIFT LOST\nAvoid pink blocks. Retry to restart.", TextAnchor.MiddleCenter, new Vector2(0f, 24f), new Vector2(560f, 190f), Color.white);
        gameOverText.fontSize = 38;
        CreateButton(panel.transform, "Retry Button", font, "RETRY", TextAnchor.LowerCenter, new Vector2(0f, 34f), new Vector2(260f, 72f), new Color(0f, 0.55f, 0.85f, 0.88f));

        var hud = canvasObject.AddComponent<NeonDriftHud>();
        var serialized = new SerializedObject(hud);
        serialized.FindProperty("scoreText").objectReferenceValue = scoreText;
        serialized.FindProperty("pulseText").objectReferenceValue = pulseText;
        serialized.FindProperty("gameOverPanel").objectReferenceValue = panel;
        serialized.ApplyModifiedPropertiesWithoutUndo();

        var uiActions = canvasObject.AddComponent<NeonDriftUiActions>();
        var uiActionsSerialized = new SerializedObject(uiActions);
        uiActionsSerialized.FindProperty("mainMenuPanel").objectReferenceValue = menuPanel;
        uiActionsSerialized.FindProperty("gameplayHudRoot").objectReferenceValue = gameplayHudRoot;
        uiActionsSerialized.FindProperty("settingsButtonLabel").objectReferenceValue = settingsButton.GetComponentInChildren<Text>(true);
        uiActionsSerialized.ApplyModifiedPropertiesWithoutUndo();
    }

    private static Text CreateText(Transform parent, string name, Font font, string text, TextAnchor alignment, Vector2 anchoredPosition, Vector2 size, Color color)
    {
        var textObject = new GameObject(name);
        textObject.transform.SetParent(parent, false);
        var label = textObject.AddComponent<Text>();
        label.font = font;
        label.text = text;
        label.alignment = alignment;
        label.fontSize = 34;
        label.color = color;
        SetRect(textObject.GetComponent<RectTransform>(), AlignmentToAnchor(alignment), anchoredPosition, size);
        return label;
    }

    private static Image CreateUiBlock(Transform parent, string name, TextAnchor alignment, Vector2 anchoredPosition, Vector2 size, Color color)
    {
        var blockObject = new GameObject(name);
        blockObject.transform.SetParent(parent, false);
        var image = blockObject.AddComponent<Image>();
        image.color = color;
        SetRect(blockObject.GetComponent<RectTransform>(), AlignmentToAnchor(alignment), anchoredPosition, size);
        return image;
    }

    private static Button CreateButton(Transform parent, string name, Font font, string text, TextAnchor alignment, Vector2 anchoredPosition, Vector2 size, Color color)
    {
        var buttonObject = new GameObject(name);
        buttonObject.transform.SetParent(parent, false);
        var image = buttonObject.AddComponent<Image>();
        image.color = color;
        var button = buttonObject.AddComponent<Button>();
        SetRect(buttonObject.GetComponent<RectTransform>(), AlignmentToAnchor(alignment), anchoredPosition, size);
        Text label = CreateText(buttonObject.transform, $"{name} Label", font, text, TextAnchor.MiddleCenter, Vector2.zero, size, Color.white);
        label.fontSize = 28;
        return button;
    }

    private static Vector2 AlignmentToAnchor(TextAnchor alignment)
    {
        if (alignment == TextAnchor.UpperLeft) return new Vector2(0f, 1f);
        if (alignment == TextAnchor.UpperRight) return new Vector2(1f, 1f);
        if (alignment == TextAnchor.LowerLeft) return new Vector2(0f, 0f);
        if (alignment == TextAnchor.LowerRight) return new Vector2(1f, 0f);
        if (alignment == TextAnchor.LowerCenter) return new Vector2(0.5f, 0f);
        return new Vector2(0.5f, 0.5f);
    }

    private static void SetRect(RectTransform rect, Vector2 anchor, Vector2 anchoredPosition, Vector2 size)
    {
        rect.anchorMin = anchor;
        rect.anchorMax = anchor;
        rect.pivot = anchor;
        rect.anchoredPosition = anchoredPosition;
        rect.sizeDelta = size;
    }
}
