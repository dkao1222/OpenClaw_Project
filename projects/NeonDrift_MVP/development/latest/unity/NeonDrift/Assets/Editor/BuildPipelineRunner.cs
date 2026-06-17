using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public static class BuildPipelineRunner
{
    private const string ScenePath = "Assets/Scenes/Main.unity";

    public static void ValidateProject()
    {
        EnsureScene();
    }

    public static void BuildIOS()
    {
        Build(BuildTarget.iOS, "Builds/iOS");
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

    private static void EnsureScene()
    {
        Directory.CreateDirectory("Assets/Scenes");
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

        var session = new GameObject("NeonDrift Session");
        session.AddComponent<GameSessionController>();
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

        var panel = new GameObject("Game Over Panel");
        panel.transform.SetParent(canvasObject.transform, false);
        var panelImage = panel.AddComponent<Image>();
        panelImage.color = new Color(0f, 0f, 0f, 0.72f);
        SetRect(panel.GetComponent<RectTransform>(), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(760f, 360f));
        panel.SetActive(false);

        Text gameOverText = CreateText(panel.transform, "Game Over Text", font, "DRIFT LOST\nTAP TO RETRY", TextAnchor.MiddleCenter, Vector2.zero, new Vector2(720f, 300f), Color.white);
        gameOverText.fontSize = 54;

        var hud = canvasObject.AddComponent<NeonDriftHud>();
        var serialized = new SerializedObject(hud);
        serialized.FindProperty("scoreText").objectReferenceValue = scoreText;
        serialized.FindProperty("pulseText").objectReferenceValue = pulseText;
        serialized.FindProperty("gameOverPanel").objectReferenceValue = panel;
        serialized.ApplyModifiedPropertiesWithoutUndo();
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

    private static Vector2 AlignmentToAnchor(TextAnchor alignment)
    {
        if (alignment == TextAnchor.UpperLeft) return new Vector2(0f, 1f);
        if (alignment == TextAnchor.UpperRight) return new Vector2(1f, 1f);
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