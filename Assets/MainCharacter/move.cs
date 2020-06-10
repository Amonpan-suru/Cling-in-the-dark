using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{ 
    float rotate = 0f;

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

    }
}
