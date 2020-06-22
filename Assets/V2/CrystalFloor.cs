using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalFloor : MonoBehaviour
{
    public GameObject Crystal;
    public float speed = 1.5f;
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            Crystal.transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}
