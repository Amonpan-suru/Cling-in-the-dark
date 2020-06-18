using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class buttonlink : MonoBehaviour
{
    [SerializeField] string scenename;
public void playgame()
    { 
        SceneManager.LoadScene(scenename);
    }
  

public void Quitgame(){
    Application.Quit();
}

}
