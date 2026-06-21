using NUnit.Framework;
using UnityEngine;

public sealed class NeonDriftEditModeTests
{
    [Test]
    public void RuntimeQaProbeReturnsValidJsonShape()
    {
        string json = RuntimeQaProbe.CaptureJson();
        Assert.That(json, Does.Contain("\"screenState\""));
        Assert.That(json, Does.Contain("\"screenWidth\""));
        Assert.That(json, Does.Contain("\"safeArea\""));
        Assert.That(json, Does.Contain("\"framesPerSecond\""));
    }

    [Test]
    public void GameSessionControllerCanEnterGameOver()
    {
        var sessionObject = new GameObject("Test Session");
        var session = sessionObject.AddComponent<GameSessionController>();
        session.GameOver();
        Assert.IsTrue(session.IsGameOver);
        Object.DestroyImmediate(sessionObject);
    }
}
