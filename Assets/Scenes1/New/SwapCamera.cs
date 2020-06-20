using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapCamera : MonoBehaviour
{
    public GameObject Cam1;
    public GameObject Cam2;


    private void OnTriggerStay(Collider other)
    {
        if(other.name == "Area1")
        {
            Cam1.SetActive(true);
            Cam2.SetActive(false);
        }
        if(other.name == "Area2")
        {
            Cam1.SetActive(false);
            Cam2.SetActive(true);
        }
    }
  
}
