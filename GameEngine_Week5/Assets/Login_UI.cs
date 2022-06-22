using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Login_UI : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_InputField _idfield;
    public TMP_InputField _passwordfield;
    public Button loginbutton;
    public GameObject login_panel;
    public TMP_Text panel_text;
    private void Start()
    {
        loginbutton.onClick.AddListener(OnLoginButtonClick);
    }

    public void OnLoginButtonClick()
    {
        if (_idfield.text == "adim" && _passwordfield.text == "asdf")
        {
            login_panel.SetActive(true);
            panel_text.text = "아!루";
        }
        else
        {
            login_panel.SetActive(true);
            panel_text.text = "몰?루";
        }
    }
}
