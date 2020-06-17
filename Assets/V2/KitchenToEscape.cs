using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KitchenToEscape : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Invoke("Load",1.0f);
        }
    }
    void Load()
    {
        SceneManager.LoadScene("Escape_3");
    }
}