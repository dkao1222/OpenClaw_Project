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
        InvokeRuntimeBootstrap();

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
        InvokeRuntimeBootstrap();
        string json = InvokeRuntimeQaProbeCaptureJson();
        Assert.That(json, Does.Contain("\"screenWidth\""));
        Assert.That(json, Does.Contain("\"screenHeight\""));
        Assert.That(json, Does.Contain("\"safeArea\""));
    }

    [Test]
    public void ButtonPositionsAndSizesAreVerified()
    {
        SceneManager.LoadScene("Main");
        InvokeRuntimeBootstrap();
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
        InvokeRuntimeBootstrap();
        string json = InvokeRuntimeQaProbeCaptureJson();
        Assert.That(json, Does.Contain("\"screenState\": \"menu\""));
        Assert.That(json, Does.Contain("\"hasStarted\": false"));
        Assert.That(json, Does.Contain("\"score\": 0"));
        Assert.That(json, Does.Contain("\"startFlowVerified\": true"));
        Assert.That(json, Does.Contain("\"menuLayoutVerified\": true"));
        Assert.That(json, Does.Contain("\"gameplayHudHiddenInMenu\": true"));
        Assert.That(json, Does.Contain("\"gameplayControlsHiddenInMenu\": true"));
        Assert.That(json, Does.Contain("\"earlyGameOverProtected\": true"));
        Assert.That(json, Does.Contain("\"readableHazardPacingVerified\": true"));
        Assert.That(json, Does.Contain("\"gameplayVisualsVerified\": true"));
        Assert.That(json, Does.Contain("\"gameplayVisualsHiddenInMenu\": true"));
    }

    [Test]
    public void MenuLayoutIsReadable()
    {
        SceneManager.LoadScene("Main");
        InvokeRuntimeBootstrap();
        string json = InvokeRuntimeQaProbeCaptureJson();
        Assert.That(json, Does.Contain("\"menuLayoutVerified\": true"));
        Assert.That(json, Does.Contain("\"menuElementsDoNotOverlap\": true"));
        Assert.That(json, Does.Contain("\"gameplayHudHiddenInMenu\": true"));
        Assert.That(json, Does.Contain("\"gameplayControlsHiddenInMenu\": true"));
    }

    [Test]
    public void GameplayVisualsAreReadable()
    {
        SceneManager.LoadScene("Main");
        InvokeRuntimeBootstrap();
        string json = InvokeRuntimeQaProbeCaptureJson();
        Assert.That(json, Does.Contain("\"gameplayVisualsVerified\": true"));
        Assert.That(json, Does.Contain("\"gameplayVisualsHiddenInMenu\": true"));
        Assert.That(json, Does.Contain("\"hasObjectiveText\": true"));
        Assert.That(json, Does.Contain("\"hasAvoidInstructionText\": true"));
        Assert.That(json, Does.Contain("\"hasPlayerLabel\": true"));
        Assert.That(json, Does.Contain("\"hasHazardLabel\": true"));
        Assert.That(json, Does.Contain("\"gameplayInstructionReadableVerified\": true"));
    }

    [Test]
    public void GameplayMotionIsVerified()
    {
        SceneManager.LoadScene("Main");
        InvokeRuntimeBootstrap();
        Type uiActionsType = FindType("NeonDriftUiActions");
        Type visualSyncType = FindType("NeonDriftVisualSync");
        Assert.IsNotNull(uiActionsType);
        Assert.IsNotNull(visualSyncType);

        UnityEngine.Object uiActions = UnityEngine.Object.FindObjectOfType(uiActionsType);
        UnityEngine.Object visualSync = UnityEngine.Object.FindObjectOfType(visualSyncType, true);
        Assert.IsNotNull(uiActions);
        Assert.IsNotNull(visualSync);

        uiActionsType.GetMethod("StartGame").Invoke(uiActions, null);
        bool verified = (bool)visualSyncType.GetMethod("VerifyMotionForQa").Invoke(visualSync, null);
        Assert.IsTrue(verified);
    }

    [Test]
    public void PlayerSteeringMotionIsVerified()
    {
        SceneManager.LoadScene("Main");
        InvokeRuntimeBootstrap();
        Type uiActionsType = FindType("NeonDriftUiActions");
        Type visualSyncType = FindType("NeonDriftVisualSync");
        Assert.IsNotNull(uiActionsType);
        Assert.IsNotNull(visualSyncType);

        UnityEngine.Object uiActions = UnityEngine.Object.FindObjectOfType(uiActionsType);
        UnityEngine.Object visualSync = UnityEngine.Object.FindObjectOfType(visualSyncType, true);
        Assert.IsNotNull(uiActions);
        Assert.IsNotNull(visualSync);

        uiActionsType.GetMethod("StartGame").Invoke(uiActions, null);
        bool verified = (bool)visualSyncType.GetMethod("VerifySteeringForQa").Invoke(visualSync, null);
        Assert.IsTrue(verified);
    }

    [Test]
    public void StartButtonFlowVerified()
    {
        SceneManager.LoadScene("Main");
        InvokeRuntimeBootstrap();
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
    public void EarlyGameOverIsProtected()
    {
        SceneManager.LoadScene("Main");
        InvokeRuntimeBootstrap();
        Type uiActionsType = FindType("NeonDriftUiActions");
        Type sessionType = FindType("GameSessionController");
        UnityEngine.Object uiActions = UnityEngine.Object.FindObjectOfType(uiActionsType);
        UnityEngine.Object session = UnityEngine.Object.FindObjectOfType(sessionType);
        Assert.IsNotNull(uiActions);
        Assert.IsNotNull(session);

        uiActionsType.GetMethod("StartGame").Invoke(uiActions, null);
        sessionType.GetMethod("GameOver").Invoke(session, null);
        bool isGameOver = (bool)sessionType.GetProperty("IsGameOver").GetValue(session);
        bool canSpawnHazards = (bool)sessionType.GetProperty("CanSpawnHazards").GetValue(session);
        float minimumSurvivalSeconds = (float)sessionType.GetProperty("MinimumSurvivalSeconds").GetValue(session);

        Assert.IsFalse(isGameOver);
        Assert.IsFalse(canSpawnHazards);
        Assert.GreaterOrEqual(minimumSurvivalSeconds, 6f);
    }

    [Test]
    public void CoreGameplayFunctionsAreVerified()
    {
        SceneManager.LoadScene("Main");
        InvokeRuntimeBootstrap();
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

    private static void InvokeRuntimeBootstrap()
    {
        Type bootstrapType = FindType("NeonDriftRuntimeBootstrap");
        Assert.IsNotNull(bootstrapType);
        MethodInfo ensure = bootstrapType.GetMethod("EnsureRuntimeScene", BindingFlags.Static | BindingFlags.Public);
        Assert.IsNotNull(ensure);
        ensure.Invoke(null, null);
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
