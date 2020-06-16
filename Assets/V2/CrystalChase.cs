using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalChase : MonoBehaviour
{
    // ถ้า Player เข้าพื้นที่ Area2 ให้ใช้ Crystal()

    public float speed = 4.0f;
    
    private void OnTriggerStay(Collider other)
    {
        if(other.name == "ElseArea")
        {
            Crystal();
        }       
    }
    void Crystal()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
