using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class ComplexType{
    public string name;
    public int age;
    public float height;
}
public class test_script : MonoBehaviour
{
    public ComplexType namestudy;

    private const float AttackInterval = 3f;

    private float Attack_IntervalTimer;
    // Start is called before the first frame update
    void Start()
    {
        print(message:"게임이 시작되었습니다.");
        Invoke("print_text",3f); //딜레이 로그(실행할 것, 몇초뒤 실행)
        InvokeRepeating("print_text",9f,3f);//(실행할것, 몇초동안, 몇초뒤 실행)
        //Invoke는 유니티 라이프사이클과 별개로 돌아가니 조심해야한다.
    }

    // Update is called once per frame
    void Update()
    {
        Attack_IntervalTimer += Time.deltaTime;
        if (Attack_IntervalTimer > 3f)
        {
            print_attatck();
            Attack_IntervalTimer = 0f;
        }
    }

    void print_attatck()
    {
        print(message:"공격!");
    }
    void print_text()
    {
        print(message:"테스트");
    }
}
