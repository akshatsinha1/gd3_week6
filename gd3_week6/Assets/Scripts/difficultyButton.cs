using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class difficultyButton : MonoBehaviour
{
    gameManager _gm;
    public TMP_Text highscore;

    // Start is called before the first frame update
    void Start()
    {
        _gm = GameObject.FindObjectOfType<gameManager>();
        highscore.text = "Current Highscore: " + PlayerPrefs.GetInt("highscore");
        Time.timeScale = 0;
    }

    // Update is called once per frame
   

    public void changeDifficulty(float _spawnRate)
    {
        _gm.spawnRate = new Vector2(_spawnRate, _spawnRate +1);
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
}
