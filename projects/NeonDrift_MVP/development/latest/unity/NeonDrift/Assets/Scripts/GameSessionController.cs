using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class GameSessionController : MonoBehaviour
{
    public static int Score { get; private set; }
    public static GameSessionController Instance { get; private set; }

    private bool gameOver;
    private float scoreTimer;

    public bool IsGameOver => gameOver;

    private void Awake()
    {
        Instance = this;
        Score = 0;
        Time.timeScale = 1f;
    }

    private void Update()
    {
        if (gameOver)
        {
            if (Input.GetMouseButtonDown(0) || Input.touchCount > 0 || Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
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
        if (gameOver)
        {
            return;
        }

        gameOver = true;
        Time.timeScale = 0f;
    }
}
