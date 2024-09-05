using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject[] targetPrefabs;
    public bool isGameOver = false;
    public int score, lives;
    public GameObject gameOverScreen;
    public TMP_Text livesText, scoreText, gameOverScore, highScoreText;
    public Vector2 spawnRate;
    // Start is called before the first frame update

    void Start()
    {
        StartCoroutine(spawnTargets());
        livesText.text = "Lives: " + lives.ToString();
        scoreText.text = "Score: " + score.ToString();
    }

    IEnumerator spawnTargets()
    {
        while(!isGameOver)
        {
            yield return new WaitForSeconds(Random.Range(spawnRate.x, spawnRate.y));
            int randomSpawnIndex = Random.Range(0, targetPrefabs.Length);
            Instantiate(targetPrefabs[randomSpawnIndex]);
        }
    }

    public void updateScore(int scoreChange)
    {
        score += scoreChange;
        scoreText.text = "Score: " + score.ToString();
    }

    public void gameOver()
    {
       
        isGameOver = true;
        gameOverScreen.SetActive(true);
        gameOverScore.text = "Your Score: " + score.ToString();
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("highscore");
        Time.timeScale = 0;

        if(PlayerPrefs.GetInt("highscore") < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
        
    }

    public void restartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   
}
