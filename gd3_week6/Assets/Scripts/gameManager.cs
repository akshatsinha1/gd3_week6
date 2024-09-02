using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject[] targetPrefabs;
    public bool isGameOver = false;
    public int score, lives;

    [SerializeField] Vector2 spawnRate;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("Function Name", 2, 3);
        StartCoroutine(spawnTargets());
    }

    private void Update()
    {
        if (lives <= 0) isGameOver = true;
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
   
}
