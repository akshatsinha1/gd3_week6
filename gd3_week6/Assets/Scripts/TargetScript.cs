using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    Rigidbody rb;
    public Vector2 randomForce, randomTorque;
    public float xRange;
    gameManager _gm;
    public int myScore = 2;

    

    // Start is called before the first frame update
    void Start()
    {
        
        _gm = GameObject.FindObjectOfType<gameManager>();

        rb = GetComponent<Rigidbody>();

        //add a random upwards force
        rb.AddForce(Vector3.up * Random.Range(randomForce.x, randomForce.y), ForceMode.Impulse);

        
        
        //add a random rotation/torque
        rb.AddTorque(Random.Range(randomTorque.x, randomTorque.y), Random.Range(randomTorque.x, randomTorque.y), Random.Range(randomTorque.x, randomTorque.y), ForceMode.Impulse);

        //random starting position
        transform.position = new Vector3(Random.Range(-xRange, xRange), -1, 0);
    }

    private void OnMouseOver()
    {
        //gameobject.findojectoftype<cursormanager>().isOverBug = true;
        
    }
    private void OnMouseExit()
    {
        //gameobject.findojectoftype<cursormanager>().isOverBug = false;
    }

    private void OnMouseDown()
    {
        if(transform.tag == "GoodObject")
        {
            _gm.updateScore(myScore);
            Destroy(gameObject);
        }

        if(transform.tag == "BadObject")
        {
            _gm.lives--;
            if (_gm.lives <= 0) _gm.gameOver();

            _gm.livesText.text = "Lives: " + _gm.lives.ToString();

            Destroy(gameObject);
        }
    }
}
