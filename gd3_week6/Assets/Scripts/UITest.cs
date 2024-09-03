using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UITest : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TMP_Text usernameDisplay;
    public Toggle toggleButton;
    public Slider _slider;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (toggleButton.isOn == true) usernameDisplay.gameObject.SetActive(true);
        //else usernameDisplay.gameObject.SetActive(false);


        usernameDisplay.gameObject.SetActive(toggleButton.isOn);
    }

    public void updateUsername()
    {
        usernameDisplay.text = "username: " + usernameInput.text;
    }
}
