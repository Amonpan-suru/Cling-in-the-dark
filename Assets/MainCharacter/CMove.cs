﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMove : MonoBehaviour
{
    [SerializeField] float speed;

    private bool walk;
    void Update()
    {
       
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-speed*Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed*Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0f, 0f, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0f, 0f, -speed * Time.deltaTime);
        }
        
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                speed = speed + 2f;
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                speed = speed - 2f;
            }
        

    }
}
