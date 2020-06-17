using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KitchenToEscape : MonoBehaviour
{
    private void OnCollisionEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("NightmareEscape");
        }
    }
}