using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class buttonlink : MonoBehaviour
{
    [SerializeField] string scenename;
public void playgame()
    { 
        Example();
        SceneManager.LoadScene(scenename);
    }
    IEnumerator Example()
    {
        
        yield return new WaitForSecondsRealtime(3);
        
    }

public void Quitgame(){
    Application.Quit();
}

}
