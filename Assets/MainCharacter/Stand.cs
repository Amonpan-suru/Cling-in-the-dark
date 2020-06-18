using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stand : MonoBehaviour
{

    public float Timer = 0;

    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer > 10f)
        {
            SceneManager.LoadScene("Cut1");
        }
    }
}
