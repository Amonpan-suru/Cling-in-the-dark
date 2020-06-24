using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorChase : MonoBehaviour
{
    public GameObject Object;
    public float speed = 3.0f;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Object.transform.position += Vector3.right * speed * Time.deltaTime;
        }
        //Debug.Log("Active");
    }
}
