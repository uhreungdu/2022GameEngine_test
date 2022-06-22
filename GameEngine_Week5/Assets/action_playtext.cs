using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class action_playtext : MonoBehaviour
{
    private TMP_Text text;
    public PlayerInput input_p;
    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = input_p.currentActionMap.name;
    }
}
