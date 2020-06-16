using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    Light Light1;
    bool Dead = false;

    public void EndingGame()
    {
        if( Light1.intensity == 0.0f )
        {
            Dead = true;
            Debug.Log("YOU DIED");
            Restart();
        }
    }

    void Restart()
    {
        //SceneManager.LoadScene("Nightmare");
    }
}
