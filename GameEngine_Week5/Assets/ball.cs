using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody _rigid;
    private Vector3 direction;
    private void Awake()
    {
        _rigid = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hori = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        print(hori +", " +vert);
        direction = new Vector3(hori,0,vert);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //print("?");
            Vector3 jump = new Vector3(0, 50f, 0);
            direction += jump;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            Camera cam = Camera.main;
            Ray ray = cam.ScreenPointToRay(pos);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                print(hitInfo.collider.name);
            }
        }

        
        
    }

    private void FixedUpdate()
    {
        _rigid.AddForce(direction * 300f * Time.deltaTime);
    }
}
