﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMove : MonoBehaviour
{
    [SerializeField] float speed;
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
