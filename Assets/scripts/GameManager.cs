using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player Player;

    private int score;
    public Text scoreText;
    public GameObject PlayButton;
    public GameObject gameOver;
    private void Awake()
    {
        Application.targetFrameRate = 60;

        Pause();

    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        gameOver.SetActive(false);
        PlayButton.SetActive(false);

        Time.timeScale = 1f;
        Player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for(int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }

    }

    public void Pause()
    {
        Time.timeScale = 0f;
        Player.enabled = false;
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        PlayButton.SetActive(true);

        Pause();
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString(); 
    }
}
