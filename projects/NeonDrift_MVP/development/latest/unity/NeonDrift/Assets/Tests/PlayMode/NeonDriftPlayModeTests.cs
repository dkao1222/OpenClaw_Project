using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class NeonDriftPlayModeTests
{
    [Test]
    public void MainSceneLoadsWithProbeAndHud()
    {
        SceneManager.LoadScene("Main");

        Assert.IsNotNull(Object.FindObjectOfType<GameSessionController>());
        Assert.IsNotNull(Object.FindObjectOfType<NeonDriftHud>());
        Assert.IsNotNull(Object.FindObjectOfType<RuntimeQaProbe>());

        string json = RuntimeQaProbe.CaptureJson();
        Assert.That(json, Does.Contain("\"hasCanvas\": true"));
        Assert.That(json, Does.Contain("\"hasScoreText\": true"));
        Assert.That(json, Does.Contain("\"hasPlayer\": true"));
    }

    [Test]
    public void ProbeCapturesScreenAndSafeArea()
    {
        SceneManager.LoadScene("Main");
        string json = RuntimeQaProbe.CaptureJson();
        Assert.That(json, Does.Contain("\"screenWidth\""));
        Assert.That(json, Does.Contain("\"screenHeight\""));
        Assert.That(json, Does.Contain("\"safeArea\""));
    }
}
