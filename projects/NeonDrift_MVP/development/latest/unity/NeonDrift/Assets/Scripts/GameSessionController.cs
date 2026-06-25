using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class GameSessionController : MonoBehaviour
{
    public static int Score { get; private set; }
    public static GameSessionController Instance { get; private set; }

    private bool gameOver;
    private bool paused;
    private bool started;
    private float scoreTimer;
    private float gameplayTimer;
    private int combo;
    private int wave = 1;
    private float boostCharge;
    private int meaningfulSteerEvents;
    private bool avoidanceChoiceVerified;
    private int pickupCount;
    private int hazardCount;
    private int boostCount;
    private int comboCount;
    private float lastHazardSpawnX;
    private string scoreDeltaReason = "none";
    private string pulseDeltaReason = "none";
    private string lastCollisionType = "none";
    private string lastFailureReason = "none";

    public bool IsGameOver => gameOver;
    public bool IsPaused => paused;
    public bool HasStarted => started;
    public float GameplayTime => gameplayTimer;
    public float MinimumSurvivalSeconds => 6f;
    public int Combo => combo;
    public int Wave => wave;
    public int Multiplier => Mathf.Clamp(1 + combo / 10 + Mathf.Max(0, wave - 1), 1, 5);
    public float BoostCharge => boostCharge;
    public bool PlayerInputChangesOutcomeVerified => meaningfulSteerEvents >= 2 && avoidanceChoiceVerified;
    public bool HumanAgencyVerified => PlayerInputChangesOutcomeVerified;
    public bool ContentDepthVerified => Wave >= 1 && Multiplier >= 1 && BoostCharge >= 0f && HumanAgencyVerified;
    public bool CanSpawnHazards => started && !paused && !gameOver && gameplayTimer >= 2.5f;
    public bool CanAcceptFailure => started && gameplayTimer >= MinimumSurvivalSeconds;
    public int PickupCount => pickupCount;
    public int HazardCount => hazardCount;
    public int BoostCount => boostCount;
    public int ComboCount => comboCount;
    public float LastHazardSpawnX => lastHazardSpawnX;
    public string ScoreDeltaReason => scoreDeltaReason;
    public string PulseDeltaReason => pulseDeltaReason;
    public string LastCollisionType => lastCollisionType;
    public string LastFailureReason => lastFailureReason;

    private void Awake()
    {
        Instance = this;
        Score = 0;
        combo = 0;
        wave = 1;
        boostCharge = 0f;
        meaningfulSteerEvents = 0;
        avoidanceChoiceVerified = false;
        ResetEvidenceFields();
        started = false;
        paused = false;
        gameOver = false;
        Time.timeScale = 0f;
        Application.targetFrameRate = 60;
    }

    private void OnEnable()
    {
        Instance = this;
        Application.targetFrameRate = 60;
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    private void Update()
    {
        if (!started)
        {
            return;
        }

        if (gameOver)
        {
            if (Input.GetMouseButtonDown(0) || Input.touchCount > 0 || Input.GetKeyDown(KeyCode.Space))
            {
                Retry();
            }
            return;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }

        if (paused)
        {
            return;
        }

        gameplayTimer += Time.deltaTime;
        wave = 1 + Mathf.FloorToInt(gameplayTimer / 15f);
        boostCharge = Mathf.Clamp01(boostCharge + Time.deltaTime * 0.035f);

        scoreTimer += Time.deltaTime;
        if (scoreTimer >= 0.1f)
        {
            combo += 1;
            Score += Multiplier;
            comboCount = combo;
            scoreDeltaReason = "survival_tick";
            pulseDeltaReason = "passive_charge";
            scoreTimer = 0f;
        }
    }

    public void RegisterHazardSpawn(float spawnX)
    {
        hazardCount += 1;
        lastHazardSpawnX = spawnX;
    }

    public void CollectBoostCell()
    {
        if (!started || paused || gameOver)
        {
            return;
        }

        boostCharge = Mathf.Clamp01(boostCharge + 0.25f);
        combo += 5;
        Score += 25 * Multiplier;
        pickupCount += 1;
        boostCount += 1;
        comboCount = combo;
        scoreDeltaReason = "boost_pickup";
        pulseDeltaReason = "boost_pickup";
    }

    public void RecordMeaningfulSteer(float startX, float endX)
    {
        if (!started || paused || gameOver)
        {
            return;
        }

        if (Mathf.Abs(endX - startX) >= 0.03f)
        {
            meaningfulSteerEvents += 1;
            combo += 1;
            comboCount = combo;
            scoreDeltaReason = "near_miss";
        }
    }

    public void RecordAvoidanceChoice(bool avoidedThreat)
    {
        if (!started || paused || gameOver)
        {
            return;
        }

        avoidanceChoiceVerified = avoidanceChoiceVerified || avoidedThreat;
        if (avoidedThreat)
        {
            boostCharge = Mathf.Clamp01(boostCharge + 0.1f);
            Score += 5 * Multiplier;
            scoreDeltaReason = "near_miss";
            pulseDeltaReason = "near_miss_reward";
        }
    }

    public void GameOver(string collisionType = "hazard_body")
    {
        if (!CanAcceptFailure || gameOver)
        {
            return;
        }

        lastCollisionType = collisionType;
        lastFailureReason = collisionType == "track_edge" ? "left_track_bounds" : "hazard_collision";
        scoreDeltaReason = "collision_penalty";
        pulseDeltaReason = "collision_loss";
        gameOver = true;
        SetGameOverPanelVisible(true);
        Time.timeScale = 0f;
    }

    public void TogglePause()
    {
        if (!started || gameOver)
        {
            return;
        }

        paused = !paused;
        Time.timeScale = paused ? 0f : 1f;
    }

    public void StartGame()
    {
        Instance = this;
        if (started)
        {
            return;
        }

        started = true;
        paused = false;
        gameOver = false;
        scoreTimer = 0f;
        gameplayTimer = 0f;
        combo = 0;
        wave = 1;
        boostCharge = 0f;
        meaningfulSteerEvents = 0;
        avoidanceChoiceVerified = false;
        ResetEvidenceFields();
        Score = 0;
        Time.timeScale = 1f;
    }

    public void Retry()
    {
        Time.timeScale = 0f;
        Score = 0;
        combo = 0;
        wave = 1;
        boostCharge = 0f;
        meaningfulSteerEvents = 0;
        avoidanceChoiceVerified = false;
        ResetEvidenceFields();
        started = false;
        paused = false;
        gameOver = false;
        SetGameOverPanelVisible(false);
        scoreTimer = 0f;
        gameplayTimer = 0f;

        DriftPlayerController player = DriftPlayerController.Instance != null ? DriftPlayerController.Instance : FindObjectOfType<DriftPlayerController>();
        if (player != null)
        {
            player.ClearUiSteer();
            player.transform.position = new Vector3(0f, -3.6f, 0f);
        }
    }

    private void ResetEvidenceFields()
    {
        pickupCount = 0;
        hazardCount = 0;
        boostCount = 0;
        comboCount = 0;
        lastHazardSpawnX = 0f;
        scoreDeltaReason = "none";
        pulseDeltaReason = "none";
        lastCollisionType = "none";
        lastFailureReason = "none";
    }

    private static void SetGameOverPanelVisible(bool visible)
    {
        GameObject panel = FindObjectByNameIncludingInactive("Game Over Panel");
        if (panel != null)
        {
            panel.SetActive(visible);
        }
    }

    private static GameObject FindObjectByNameIncludingInactive(string objectName)
    {
        Transform[] transforms = Resources.FindObjectsOfTypeAll<Transform>();
        foreach (Transform transform in transforms)
        {
            if (transform != null && transform.name == objectName)
            {
                return transform.gameObject;
            }
        }
        return null;
    }
}
