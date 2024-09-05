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

    // Start is called before the first frame update
    void Start()
    {
        usernameDisplay.text = "username: " + PlayerPrefs.GetString("username");
    }

    // Update is called once per frame
    void Update()
    {
        usernameDisplay.gameObject.SetActive(toggleButton.isOn);
    }

    public void updateUsername()
    {
        PlayerPrefs.SetString("username", usernameInput.text);
        usernameDisplay.text = "username: " + usernameInput.text;
    }
}
