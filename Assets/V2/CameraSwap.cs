using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;

    private void OnTriggerStay(Collider other)
    {
        if(other.name == "EscapeArea1")
        {
            Camera1.SetActive(true);
            Camera2.SetActive(false);
        
        }
        if(other.name == "EscapeArea2")
        {
            Camera1.SetActive(false);
            Camera2.SetActive(true);
        }   
        Debug.Log("hi");
    }
}
