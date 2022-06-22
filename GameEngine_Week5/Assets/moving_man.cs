using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class moving_man : MonoBehaviour
{
    private Rigidbody rid;
    private Vector3 direction;

    private void Awake()
    {
        rid = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rid.AddForce(direction);
    }

    public void OnMove(InputValue value)
    {
        print(value.Get<Vector2>());
        direction = new Vector3(value.Get<Vector2>().x,0,value.Get<Vector2>().y);
    }
}
