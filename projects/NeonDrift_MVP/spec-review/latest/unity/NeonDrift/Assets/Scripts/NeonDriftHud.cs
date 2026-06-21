using UnityEngine;
using UnityEngine.UI;

public sealed class NeonDriftHud : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Text pulseText;
    [SerializeField] private GameObject gameOverPanel;

    private void Update()
    {
        if (scoreText != null)
        {
            scoreText.text = $"SCORE {GameSessionController.Score:0000}";
        }

        if (pulseText != null)
        {
            float pulsePercent = Mathf.PingPong(Time.unscaledTime * 0.35f, 1f) * 100f;
            pulseText.text = $"PULSE {pulsePercent:00}%";
        }

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(GameSessionController.Instance != null && GameSessionController.Instance.IsGameOver);
        }
    }
}
