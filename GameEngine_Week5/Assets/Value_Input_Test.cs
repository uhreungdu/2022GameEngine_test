using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Value_Input_Test : MonoBehaviour
{
    public void OnValueChanged(string value)
    {
        print("text = "+value);
    }
}
