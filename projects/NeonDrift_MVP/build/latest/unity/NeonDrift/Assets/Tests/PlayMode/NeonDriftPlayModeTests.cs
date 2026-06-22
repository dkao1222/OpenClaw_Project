using System;
using System.Reflection;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class NeonDriftPlayModeTests
{
    [Test]
    public void MainSceneLoadsWithProbeAndHud()
    {
        SceneManager.LoadScene("Main");

        Assert.IsNotNull(FindObjectByTypeName("GameSessionController"));
        Assert.IsNotNull(FindObjectByTypeName("NeonDriftHud"));
        Assert.IsNotNull(FindObjectByTypeName("RuntimeQaProbe"));

        string json = InvokeRuntimeQaProbeCaptureJson();
        Assert.That(json, Does.Contain("\"hasCanvas\": true"));
        Assert.That(json, Does.Contain("\"hasScoreText\": true"));
        Assert.That(json, Does.Contain("\"hasPlayer\": true"));
    }

    [Test]
    public void ProbeCapturesScreenAndSafeArea()
    {
        SceneManager.LoadScene("Main");
        string json = InvokeRuntimeQaProbeCaptureJson();
        Assert.That(json, Does.Contain("\"screenWidth\""));
        Assert.That(json, Does.Contain("\"screenHeight\""));
        Assert.That(json, Does.Contain("\"safeArea\""));
    }

    [Test]
    public void ButtonPositionsAndSizesAreVerified()
    {
        SceneManager.LoadScene("Main");
        string json = InvokeRuntimeQaProbeCaptureJson();
        Assert.That(json, Does.Contain("\"startButtonRect\""));
        Assert.That(json, Does.Contain("\"settingsButtonRect\""));
        Assert.That(json, Does.Contain("\"pauseButtonRect\""));
        Assert.That(json, Does.Contain("\"retryButtonRect\""));
        Assert.That(json, Does.Contain("\"leftControlZoneRect\""));
        Assert.That(json, Does.Contain("\"rightControlZoneRect\""));
        Assert.That(json, Does.Contain("\"buttonLayoutVerified\": true"));
        Assert.That(json, Does.Contain("\"menuButtonSizeVerified\": true"));
        Assert.That(json, Does.Contain("\"pauseRetryButtonSizeVerified\": true"));
        Assert.That(json, Does.Contain("\"controlZoneSizeVerified\": true"));
        Assert.That(json, Does.Contain("\"controlsInsideSafeArea\": true"));
        Assert.That(json, Does.Contain("\"controlsDoNotOverlap\": true"));
    }

    [Test]
    public void InitialStateWaitsForStart()
    {
        SceneManager.LoadScene("Main");
        string json = InvokeRuntimeQaProbeCaptureJson();
        Assert.That(json, Does.Contain("\"screenState\": \"menu\""));
        Assert.That(json, Does.Contain("\"hasStarted\": false"));
        Assert.That(json, Does.Contain("\"score\": 0"));
        Assert.That(json, Does.Contain("\"startFlowVerified\": true"));
        Assert.That(json, Does.Contain("\"menuLayoutVerified\": true"));
        Assert.That(json, Does.Contain("\"gameplayHudHiddenInMenu\": true"));
        Assert.That(json, Does.Contain("\"gameplayControlsHiddenInMenu\": true"));
    }

    [Test]
    public void MenuLayoutIsReadable()
    {
        SceneManager.LoadScene("Main");
        string json = InvokeRuntimeQaProbeCaptureJson();
        Assert.That(json, Does.Contain("\"menuLayoutVerified\": true"));
        Assert.That(json, Does.Contain("\"menuElementsDoNotOverlap\": true"));
        Assert.That(json, Does.Contain("\"gameplayHudHiddenInMenu\": true"));
        Assert.That(json, Does.Contain("\"gameplayControlsHiddenInMenu\": true"));
    }

    [Test]
    public void StartButtonFlowVerified()
    {
        SceneManager.LoadScene("Main");
        Type uiActionsType = FindType("NeonDriftUiActions");
        Type sessionType = FindType("GameSessionController");
        Assert.IsNotNull(uiActionsType);
        Assert.IsNotNull(sessionType);

        UnityEngine.Object uiActions = UnityEngine.Object.FindObjectOfType(uiActionsType);
        UnityEngine.Object session = UnityEngine.Object.FindObjectOfType(sessionType);
        Assert.IsNotNull(uiActions);
        Assert.IsNotNull(session);

        bool startedBefore = (bool)sessionType.GetProperty("HasStarted").GetValue(session);
        Assert.IsFalse(startedBefore);

        uiActionsType.GetMethod("StartGame").Invoke(uiActions, null);
        bool startedAfter = (bool)sessionType.GetProperty("HasStarted").GetValue(session);
        Assert.IsTrue(startedAfter);
        Assert.AreEqual(1f, Time.timeScale);
    }

    [Test]
    public void CoreGameplayFunctionsAreVerified()
    {
        SceneManager.LoadScene("Main");
        string json = InvokeRuntimeQaProbeCaptureJson();
        Assert.That(json, Does.Contain("\"coreGameplayObjectsVerified\": true"));
        Assert.That(json, Does.Contain("\"scoringSystemVerified\": true"));
        Assert.That(json, Does.Contain("\"pauseSystemVerified\": true"));
        Assert.That(json, Does.Contain("\"failureRetrySystemVerified\": true"));
        Assert.That(json, Does.Contain("\"hasPlayer\": true"));
        Assert.That(json, Does.Contain("\"hasHazardSpawner\": true"));
    }

    private static UnityEngine.Object FindObjectByTypeName(string typeName)
    {
        Type type = FindType(typeName);
        Assert.IsNotNull(type);
        return UnityEngine.Object.FindObjectOfType(type);
    }

    private static string InvokeRuntimeQaProbeCaptureJson()
    {
        Type probeType = FindType("RuntimeQaProbe");
        Assert.IsNotNull(probeType);
        MethodInfo capture = probeType.GetMethod("CaptureJson", BindingFlags.Static | BindingFlags.Public);
        Assert.IsNotNull(capture);
        return (string)capture.Invoke(null, null);
    }

    private static Type FindType(string typeName)
    {
        foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            Type type = assembly.GetType(typeName);
            if (type != null)
            {
                return type;
            }
        }
        return null;
    }
}
