using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wee_2_C : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var b = transform.parent;
        transform.parent = null; //계층 구조를 깨고 root가 됨
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
