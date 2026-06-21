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
