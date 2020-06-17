using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MCRoomToKitchen : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Invoke("Load",1.0f);
            //SceneManager.LoadScene("Escape_2");
        }
    }
    void Load()
    {
        SceneManager.LoadScene("Escape_2");
    }
}
