﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class buttonlink : MonoBehaviour
{
public void playgame()
    {
        SceneManager.LoadScene("Chapter1");
    }

public void Quitgame(){
    Application.Quit();
}

}
