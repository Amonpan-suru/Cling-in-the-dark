using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stand : MonoBehaviour
{
    public string Scene;
    public float Timer = 0;

    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer > 6f)
        {
            SceneManager.LoadScene(Scene);
        }
    }
}
