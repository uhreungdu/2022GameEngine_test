using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subscriber : MonoBehaviour
{
    public string evetname;
    // Start is called before the first frame update
    void Start()
    {
        EventManager.Instance.Subcribe(evetname,OnEvent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEvent(object param)
    {
        print($"{evetname}: 가 발동되었습니다.");
    }
}
