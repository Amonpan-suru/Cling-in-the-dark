using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightDecreas : MonoBehaviour
{
    public Light Light1;
    public string Scene;

    public static bool Alive = true;

    public static bool getAlive { get { return Alive; } }

    private void OnTriggerEnter( Collider collision )
    {
        if ( collision.gameObject.tag == "DarkHand" )
        {
            Light1.intensity -= 0.5f;
        }
        if (collision.gameObject.tag == "CrystalChase")
        {
            Light1.intensity -= 10.0f;
        }
        if ( Light1.intensity == 0.0f )
        {
            Alive = false;
            //Reload();
            Invoke("Reload",2.0f);
        }       
    }
    public void Reload()
    {
        Alive = true;
        SceneManager.LoadScene(Scene);
        Time.timeScale = 1;

    }
}
