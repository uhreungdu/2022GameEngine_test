using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Week_2_A : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject studyBObje;
    void Start()
    {
        //studyBObje = GameObject.FindObjectOfType<Week_2_B>().gameObject; //컨포넌트를 가지고 있는 오브젝트를 찾는 방식
        //중간에 objects로 바꾸면 배열로 여러개 얻어옴
        
        /*
        studyBObje = new GameObject("B");
        studyBObje.AddComponent<Week_2_B>(); //AddComponent를 이용하여 스크립트 추가
        print(studyBObje.name);

        var studyB = studyBObje.GetComponent<Week_2_B>();
        studyBObje.SendMessage("SayHello"); // 게임오브젝트에 직접적으로 보내기 가능
        studyB.SendMessage("SayHello"); //함수에 메세지를 보내 접근
        */

        var b = transform.Find("B"); //하이어라키뷰의 전역을 찾는것이 아닌 계층구조 내의 것만 찾기 가능
        print(b.name); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
