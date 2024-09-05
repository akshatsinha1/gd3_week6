using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class difficultyButton2 : MonoBehaviour
{
    Button _difficultyButton;
    // Start is called before the first frame update
    void Start()
    {
        _difficultyButton = GetComponent<Button>();
        _difficultyButton.onClick.AddListener(setDifficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setDifficulty()
    {
        GameObject.FindObjectOfType<gameManager>().spawnRate = new Vector2(0, 1);
    }
}
