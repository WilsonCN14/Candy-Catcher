using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI livesText;
    [SerializeField] GameObject titleScreen;
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] TextMeshProUGUI finalScoreText;
    [SerializeField] SpawnManager spawnManager;
    private int score;
    private int livesRemaining;

    // Start is called before the first frame update
    void Start()
    {
        spawnManager = GameObject.Find("Spawn Manager").GetComponent<SpawnManager>();
    }

    public void StartGame() 
    {
        score = 0;
        scoreText.SetText("Score: " + score);
        livesRemaining = 3;
        livesText.SetText("Lives: " + livesRemaining);
        titleScreen.SetActive(false);
        spawnManager.StartSpawning();
    }

    public void UpdateScore(int addToScore)
    {
        score += addToScore;
        scoreText.SetText("Score: " + score);
    }

    public void LostLife()
    {
        livesRemaining --;
        livesText.SetText("Lives: " + livesRemaining);

        if (livesRemaining == 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        spawnManager.StopSpawning();
        finalScoreText.SetText("You scored " + score + " points!");
        gameOverScreen.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
