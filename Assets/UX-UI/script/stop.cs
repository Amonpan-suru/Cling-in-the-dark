using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class stop : MonoBehaviour
{
    public PlayableDirector director;
    public string Scene;



    void OnEnable()
    {
        director.stopped += OnPlayableDirectorStopped;
    }

    void OnPlayableDirectorStopped(PlayableDirector aDirector)
    {
        if (director == aDirector)
        {
            SceneManager.LoadScene(Scene);
        }
            
    }

    void OnDisable()
    {
        director.stopped -= OnPlayableDirectorStopped;
    }
}
