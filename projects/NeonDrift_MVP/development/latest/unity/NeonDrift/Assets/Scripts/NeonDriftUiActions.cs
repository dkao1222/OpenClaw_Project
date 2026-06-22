using UnityEngine;
using UnityEngine.UI;

public sealed class NeonDriftUiActions : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private Text settingsButtonLabel;

    private void Awake()
    {
        BindButton("Start Button", StartGame);
        BindButton("Settings Button", ShowSettingsFeedback);
        BindButton("Pause Button", TogglePause);
        BindButton("Retry Button", Retry);
    }

    private void BindButton(string buttonName, UnityEngine.Events.UnityAction action)
    {
        Button button = FindButton(buttonName);
        if (button == null)
        {
            Debug.LogError($"Required UI button missing: {buttonName}");
            return;
        }

        button.onClick.RemoveListener(action);
        button.onClick.AddListener(action);
        button.interactable = true;
    }

    private Button FindButton(string buttonName)
    {
        Button[] buttons = GetComponentsInChildren<Button>(true);
        foreach (Button button in buttons)
        {
            if (button != null && button.name == buttonName)
            {
                return button;
            }
        }
        return null;
    }

    public void StartGame()
    {
        if (mainMenuPanel != null)
        {
            mainMenuPanel.SetActive(false);
        }
        GameSessionController session = GameSessionController.Instance != null ? GameSessionController.Instance : FindObjectOfType<GameSessionController>();
        session?.StartGame();
    }

    public void ShowSettingsFeedback()
    {
        if (settingsButtonLabel != null)
        {
            settingsButtonLabel.text = "SOUND ON";
        }
    }

    public void TogglePause()
    {
        GameSessionController.Instance?.TogglePause();
    }

    public void Retry()
    {
        GameSessionController.Instance?.Retry();
    }
}
