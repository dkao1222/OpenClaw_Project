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
