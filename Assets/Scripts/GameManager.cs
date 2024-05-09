using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverView;
    public Text scoreView;
    
    private int _score;

    public int Score
    {
        get => _score;
        set
        {
            _score = value;
            scoreView.text = value.ToString();
        }
    }

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void GameOver()
    {
        gameOverView.SetActive(true);
        Time.timeScale = 0;
    }
}
