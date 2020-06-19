using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class colliWarp : MonoBehaviour
{
    public string scenename;
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(scenename);
    }

}
