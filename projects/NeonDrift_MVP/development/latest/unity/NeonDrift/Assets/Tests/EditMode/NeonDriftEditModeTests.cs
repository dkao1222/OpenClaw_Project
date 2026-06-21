using System;
using System.Reflection;
using NUnit.Framework;
using UnityEngine;

public sealed class NeonDriftEditModeTests
{
    [Test]
    public void RuntimeQaProbeReturnsValidJsonShape()
    {
        string json = InvokeRuntimeQaProbeCaptureJson();
        Assert.That(json, Does.Contain("\"screenState\""));
        Assert.That(json, Does.Contain("\"screenWidth\""));
        Assert.That(json, Does.Contain("\"safeArea\""));
        Assert.That(json, Does.Contain("\"framesPerSecond\""));
    }

    [Test]
    public void GameSessionControllerCanEnterGameOver()
    {
        Type sessionType = FindType("GameSessionController");
        Assert.IsNotNull(sessionType);
        var sessionObject = new GameObject("Test Session");
        var session = sessionObject.AddComponent(sessionType);
        sessionType.GetMethod("GameOver", BindingFlags.Instance | BindingFlags.Public)?.Invoke(session, null);
        object isGameOver = sessionType.GetProperty("IsGameOver", BindingFlags.Instance | BindingFlags.Public)?.GetValue(session);
        Assert.AreEqual(true, isGameOver);
        UnityEngine.Object.DestroyImmediate(sessionObject);
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
