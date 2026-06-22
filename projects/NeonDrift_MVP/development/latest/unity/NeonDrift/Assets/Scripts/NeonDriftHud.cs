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

public sealed class NeonDriftVisualSync : MonoBehaviour
{
    [SerializeField] private RectTransform trackPlayfield;
    [SerializeField] private RectTransform leftLaneRail;
    [SerializeField] private RectTransform rightLaneRail;
    [SerializeField] private RectTransform playerMarker;
    [SerializeField] private RectTransform hazardMarker;

    private float hazardY = 470f;
    private float railPulse;
    private bool movedHazard;
    private bool movedPlayer;
    private Vector2 lastHazardPosition;
    private Vector2 lastPlayerPosition;

    public bool HasMotionContract => trackPlayfield != null && leftLaneRail != null && rightLaneRail != null && playerMarker != null && hazardMarker != null;
    public bool HasAnimated => movedHazard;
    public bool HasPlayerResponse => movedPlayer;

    private void Awake()
    {
        if (trackPlayfield == null) { trackPlayfield = FindRect("Track Playfield"); }
        if (leftLaneRail == null) { leftLaneRail = FindRect("Left Lane Rail"); }
        if (rightLaneRail == null) { rightLaneRail = FindRect("Right Lane Rail"); }
        if (playerMarker == null) { playerMarker = FindRect("Player Visual Marker"); }
        if (hazardMarker == null) { hazardMarker = FindRect("Hazard Visual Marker"); }
        if (hazardMarker != null) { lastHazardPosition = hazardMarker.anchoredPosition; }
        if (playerMarker != null) { lastPlayerPosition = playerMarker.anchoredPosition; }
    }

    private void Update()
    {
        Tick(Time.deltaTime);
    }

    public void Tick(float deltaTime)
    {
        GameSessionController session = GameSessionController.Instance;
        if (session == null || !session.HasStarted || session.IsPaused || session.IsGameOver)
        {
            return;
        }

        railPulse += deltaTime * 3.5f;
        hazardY -= deltaTime * 280f;
        if (hazardY < -465f)
        {
            hazardY = 470f;
        }

        if (hazardMarker != null)
        {
            hazardMarker.anchoredPosition = new Vector2(Mathf.Sin(session.GameplayTime * 1.25f) * 72f, hazardY);
            movedHazard = movedHazard || Vector2.Distance(lastHazardPosition, hazardMarker.anchoredPosition) > 10f;
            lastHazardPosition = hazardMarker.anchoredPosition;
        }

        DriftPlayerController player = DriftPlayerController.Instance != null ? DriftPlayerController.Instance : FindObjectOfType<DriftPlayerController>();
        if (player != null && playerMarker != null)
        {
            playerMarker.anchoredPosition = new Vector2(Mathf.Clamp(player.CurrentX, -3.1f, 3.1f) * 45f, playerMarker.anchoredPosition.y);
            movedPlayer = movedPlayer || Vector2.Distance(lastPlayerPosition, playerMarker.anchoredPosition) > 4f;
            lastPlayerPosition = playerMarker.anchoredPosition;
        }

        if (leftLaneRail != null)
        {
            leftLaneRail.localScale = new Vector3(1f, 1f + Mathf.Sin(railPulse) * 0.025f, 1f);
        }
        if (rightLaneRail != null)
        {
            rightLaneRail.localScale = new Vector3(1f, 1f + Mathf.Cos(railPulse) * 0.025f, 1f);
        }
    }

    public bool VerifyMotionForQa()
    {
        if (!HasMotionContract)
        {
            return false;
        }

        Vector2 before = hazardMarker.anchoredPosition;
        Tick(0.5f);
        return Vector2.Distance(before, hazardMarker.anchoredPosition) > 20f;
    }

    public bool VerifySteeringForQa()
    {
        DriftPlayerController player = DriftPlayerController.Instance != null ? DriftPlayerController.Instance : FindObjectOfType<DriftPlayerController>();
        if (player == null || playerMarker == null)
        {
            return false;
        }

        Vector2 before = playerMarker.anchoredPosition;
        player.SimulateSteerStep(1f, 0.5f);
        Tick(0.1f);
        return Vector2.Distance(before, playerMarker.anchoredPosition) > 4f;
    }

    private static RectTransform FindRect(string objectName)
    {
        Transform[] transforms = Resources.FindObjectsOfTypeAll<Transform>();
        foreach (Transform transform in transforms)
        {
            if (transform != null && transform.name == objectName)
            {
                return transform.GetComponent<RectTransform>();
            }
        }
        return null;
    }
}
