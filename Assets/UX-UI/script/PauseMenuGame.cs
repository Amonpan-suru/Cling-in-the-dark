using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuGame : MonoBehaviour
{

    public GameObject panel;
    public string Scene;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        panel.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        panel.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void MainManu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(Scene);
        
    }

    public void Quitgame()
    {
        Application.Quit();
    }

}

