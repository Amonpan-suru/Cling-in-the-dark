using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class skip : MonoBehaviour
{
    public string Scene;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
    void nexScene()
    {
        SceneManager.LoadScene(Scene);
    }

       
}
