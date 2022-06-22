using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Toggle_action_map : MonoBehaviour
{
    public PlayerInput p_input;

    public void Toggle_Map()
    {
        if (p_input.currentActionMap.name == "Game")
        {
            p_input.SwitchCurrentActionMap("UI");
        }
        else
        {
            p_input.SwitchCurrentActionMap("Game");
        }
        
    }
}
