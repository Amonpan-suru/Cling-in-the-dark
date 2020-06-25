using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed = 2.0f;

    void Update()
    {
        //if( LightDecreas.getAlive )
       // {
            CameraMovement1();
       // }
    }

    void CameraMovement1()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed + 2.0f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed - 2.0f;
        }
    }
}
