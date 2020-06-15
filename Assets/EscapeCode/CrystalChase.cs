using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalChase : MonoBehaviour
{
    public float speed = 4.0f;

    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
