using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeToFloor : MonoBehaviour
{
    private void OnCollisionEnter(Collider other)
    {      
        if(other.tag == "Player")
            {
                SceneManager.LoadScene("NightmareFloor");
            }      
    }
}
