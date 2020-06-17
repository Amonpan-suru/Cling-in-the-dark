using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightDecrease : MonoBehaviour
{
    public Light Light1;

    private static bool Alive = true;

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
            Reload();
        }       
    }
    public void Reload()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
        Time.timeScale = 1;

        Alive = true;
    }
}
