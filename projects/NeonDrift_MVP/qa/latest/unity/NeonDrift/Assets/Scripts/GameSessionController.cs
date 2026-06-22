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

    public bool IsGameOver => gameOver;
    public bool IsPaused => paused;
    public bool HasStarted => started;

    private void Awake()
    {
        Instance = this;
        Score = 0;
        started = false;
        paused = false;
        gameOver = false;
        Time.timeScale = 0f;
        Application.targetFrameRate = 60;
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

        scoreTimer += Time.deltaTime;
        if (scoreTimer >= 0.1f)
        {
            Score += 1;
            scoreTimer = 0f;
        }
    }

    public void GameOver()
    {
        if (!started || gameOver)
        {
            return;
        }

        gameOver = true;
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
        if (started)
        {
            return;
        }

        started = true;
        paused = false;
        gameOver = false;
        scoreTimer = 0f;
        Score = 0;
        Time.timeScale = 1f;
    }

    public void Retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
