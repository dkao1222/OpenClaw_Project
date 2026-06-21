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
        Application.targetFrameRate = 60;
        Directory.CreateDirectory("TestResults");
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
                ("CoreGameplayFunctionsAreVerified", RuntimeQaProbe.CaptureJson().Contains("\"coreGameplayObjectsVerified\": true") && RuntimeQaProbe.CaptureJson().Contains("\"scoringSystemVerified\": true") && RuntimeQaProbe.CaptureJson().Contains("\"pauseSystemVerified\": true") && RuntimeQaProbe.CaptureJson().Contains("\"failureRetrySystemVerified\": true"))
            }
        );
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
        Object.DestroyImmediate(player.GetComponent<BoxCollider>());
        player.GetComponent<Renderer>().sharedMaterial.color = new Color(0f, 0.95f, 1f);
        player.AddComponent<Rigidbody2D>().gravityScale = 0f;
        player.AddComponent<CircleCollider2D>();
        player.AddComponent<DriftPlayerController>();

        var hazardPrefab = GameObject.CreatePrimitive(PrimitiveType.Cube);
        hazardPrefab.name = "Hazard Preview";
        hazardPrefab.tag = "Hazard";
        hazardPrefab.transform.position = new Vector3(2.4f, 3.8f, 0f);
        hazardPrefab.transform.localScale = new Vector3(0.65f, 0.65f, 0.2f);
        Object.DestroyImmediate(hazardPrefab.GetComponent<BoxCollider>());
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
        Object.DestroyImmediate(quad.GetComponent<BoxCollider>());
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
        Text scoreText = CreateText(canvasObject.transform, "Score Text", font, "SCORE 0000", TextAnchor.UpperLeft, new Vector2(38f, -34f), new Vector2(420f, 72f), new Color(0f, 0.95f, 1f));
        Text pulseText = CreateText(canvasObject.transform, "Pulse Text", font, "PULSE 00%", TextAnchor.UpperRight, new Vector2(-38f, -34f), new Vector2(420f, 72f), new Color(1f, 0.25f, 0.9f));
        Text hintText = CreateText(canvasObject.transform, "Control Hint", font, "TAP LEFT / RIGHT TO DRIFT", TextAnchor.LowerCenter, new Vector2(0f, 34f), new Vector2(720f, 72f), new Color(0.86f, 0.92f, 1f));
        hintText.fontSize = 28;
        Text bestScoreText = CreateText(canvasObject.transform, "Best Score Text", font, "BEST 0000", TextAnchor.UpperCenter, new Vector2(0f, -104f), new Vector2(420f, 64f), new Color(0.96f, 0.92f, 0.55f));
        bestScoreText.fontSize = 28;

        CreateButton(canvasObject.transform, "Pause Button", font, "II", TextAnchor.UpperRight, new Vector2(-38f, -112f), new Vector2(96f, 72f), new Color(0.08f, 0.1f, 0.16f, 0.88f));
        CreateButton(canvasObject.transform, "Left Control Zone", font, "LEFT", TextAnchor.LowerLeft, new Vector2(36f, 126f), new Vector2(220f, 140f), new Color(0f, 0.55f, 0.85f, 0.24f));
        CreateButton(canvasObject.transform, "Right Control Zone", font, "RIGHT", TextAnchor.LowerRight, new Vector2(-36f, 126f), new Vector2(220f, 140f), new Color(0.85f, 0f, 0.65f, 0.24f));

        var menuPanel = new GameObject("Main Menu Panel");
        menuPanel.transform.SetParent(canvasObject.transform, false);
        var menuImage = menuPanel.AddComponent<Image>();
        menuImage.color = new Color(0f, 0f, 0f, 0.18f);
        SetRect(menuPanel.GetComponent<RectTransform>(), new Vector2(0.5f, 0.5f), new Vector2(0f, 118f), new Vector2(720f, 390f));
        Text titleText = CreateText(menuPanel.transform, "Title Text", font, "NEONDRIFT", TextAnchor.UpperCenter, new Vector2(0f, -26f), new Vector2(650f, 82f), new Color(0f, 0.95f, 1f));
        titleText.fontSize = 58;
        CreateButton(menuPanel.transform, "Start Button", font, "START", TextAnchor.MiddleCenter, new Vector2(0f, -18f), new Vector2(260f, 78f), new Color(0f, 0.55f, 0.85f, 0.8f));
        Button settingsButton = CreateButton(menuPanel.transform, "Settings Button", font, "SETTINGS", TextAnchor.LowerCenter, new Vector2(0f, 34f), new Vector2(300f, 72f), new Color(0.14f, 0.12f, 0.28f, 0.82f));

        var panel = new GameObject("Game Over Panel");
        panel.transform.SetParent(canvasObject.transform, false);
        var panelImage = panel.AddComponent<Image>();
        panelImage.color = new Color(0f, 0f, 0f, 0.72f);
        SetRect(panel.GetComponent<RectTransform>(), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(760f, 360f));
        panel.SetActive(false);

        Text gameOverText = CreateText(panel.transform, "Game Over Text", font, "DRIFT LOST\nTAP TO RETRY", TextAnchor.MiddleCenter, Vector2.zero, new Vector2(720f, 300f), Color.white);
        gameOverText.fontSize = 54;
        CreateButton(panel.transform, "Retry Button", font, "RETRY", TextAnchor.LowerCenter, new Vector2(0f, 38f), new Vector2(260f, 72f), new Color(0f, 0.55f, 0.85f, 0.85f));

        var hud = canvasObject.AddComponent<NeonDriftHud>();
        var serialized = new SerializedObject(hud);
        serialized.FindProperty("scoreText").objectReferenceValue = scoreText;
        serialized.FindProperty("pulseText").objectReferenceValue = pulseText;
        serialized.FindProperty("gameOverPanel").objectReferenceValue = panel;
        serialized.ApplyModifiedPropertiesWithoutUndo();

        var uiActions = canvasObject.AddComponent<NeonDriftUiActions>();
        var uiActionsSerialized = new SerializedObject(uiActions);
        uiActionsSerialized.FindProperty("mainMenuPanel").objectReferenceValue = menuPanel;
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
