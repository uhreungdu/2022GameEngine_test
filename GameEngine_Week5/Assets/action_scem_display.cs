using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class action_scem_display : MonoBehaviour
{
    public PlayerInput p_input;
    private TMP_Text text;
    
    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }
    
    void Update()
    {
        //text.text = p_input.currentControlScheme;
    }

}
