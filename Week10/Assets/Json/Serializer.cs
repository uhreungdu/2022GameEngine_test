using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public class Serializer : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        var data = new Data
        {
            Dataname = "홍길동",
            age = 20,
        };
        var jsonStr = JsonConvert.SerializeObject(data); //여러 container들도 사용할 수 있게 한다.
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
