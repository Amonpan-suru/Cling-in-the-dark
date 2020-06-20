

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public static float rotate = 0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
          
            if (rotate != -90f)
            {
                transform.rotation = Quaternion.Euler(0f, -90f, 0f);
                rotate = -90;

            }
        }
        if (Input.GetKey(KeyCode.D))
        {
           
            if (rotate != 90f)
            {
                transform.rotation = Quaternion.Euler(0f, 90f, 0f);
                rotate = 90;

            }
        }
        if (Input.GetKey(KeyCode.S))
        {

            if (rotate != 180f)
            {
                transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                rotate = 180;

            }
        }
        if (Input.GetKey(KeyCode.W))
        {

            if (rotate != 0f)
            {
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                rotate = 0;

            }
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            if(rotate != 45f)
            {
                transform.rotation = Quaternion.Euler(0f, 45f, 0f);
                rotate = 45f;
                
            }
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            if (rotate != 135f)
            {
                transform.rotation = Quaternion.Euler(0f, 135f, 0f);
                rotate = 135f;

            }
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            if (rotate != 225f)
            {
                transform.rotation = Quaternion.Euler(0f, 225f, 0f);
                rotate = 225f;

            }
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            if (rotate != 315f)
            {
                transform.rotation = Quaternion.Euler(0f, 315f, 0f);
                rotate = 315f;

            }
        }
    }
}
