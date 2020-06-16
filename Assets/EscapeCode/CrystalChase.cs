using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalChase : MonoBehaviour
{
    // ถ้า Player เข้าพื้นที่ Area2 ให้ DarkCrystal Chase เคลื่อนที่ด้วยความเร็ว 4.0f

    public float speed = 4.0f;

    private void OnTriggerStay(Collider Player)
    {
        if(Player.name == "Area2")
        {
            Crystal();
        }       
    }
    void Crystal()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
