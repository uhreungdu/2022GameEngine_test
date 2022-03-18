using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Monster : MonoBehaviour
{
    // Start is called before the first frame update
    //abstract를 적으면 해당 클래스는 컴포넌트로 사용할 수 없음
    public abstract void Cry();//abstract를 이용하여 해당 class를 상속받은 클래스들이 해당 함수를 무조건 정의하도록 한다.
    void Start()
    {
        Cry();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
