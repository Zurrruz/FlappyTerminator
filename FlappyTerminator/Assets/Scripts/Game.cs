using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    [SerializeField] private Copter _copter;
    [SerializeField] private StartScreen _startScreen;
    [SerializeField] private EndGameScreen _endGameScreen;

    private void Awake()
    {
        Time.timeScale = 0f;
    }

    private void OnEnable()
    {
        _copter.GameOver += GameOver;
        _startScreen.PlayButtonClicked += OnPlayButtonClick;
        _endGameScreen.RestartButtonClicked += OnRestartButtonClick;
    }

    private void OnDisable()
    {
        _copter.GameOver -= GameOver;
        _startScreen.PlayButtonClicked -= OnPlayButtonClick;
    }

    private void OnPlayButtonClick()
    {
        _startScreen.Close();
        StartGame();
    }
    
    private void OnRestartButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ScoreCounter.Restart();
    }

    private void StartGame()
    {
        Time.timeScale = 1.0f;
    }

    private void GameOver()
    {
        Time.timeScale = 0f;
        _endGameScreen.Open();
    }
}
