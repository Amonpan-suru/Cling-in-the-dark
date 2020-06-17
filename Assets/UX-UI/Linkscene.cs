using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Linkscene : MonoBehaviour
{
    public string scenename;
    public void NextScene()
    {
        SceneManager.LoadScene(scenename);
    }

    
    
}
