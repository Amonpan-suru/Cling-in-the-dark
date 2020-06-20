using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalChase : MonoBehaviour
{
    public float speed = 2.0f;

    private void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
