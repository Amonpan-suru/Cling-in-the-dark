using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonlink : MonoBehaviour
{
    
private void playgame()
    {
        SceneManager.LoadScene("Scene1");
    }

    private void Quitgame() => Application.Quit();

}
