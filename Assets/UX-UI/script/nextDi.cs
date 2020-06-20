using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class nextDi : MonoBehaviour
{
    public PlayableDirector director;
    public GameObject dialog;
    

    void OnPlayableDirectorStopped(PlayableDirector aDirector)
    {
        if (director == aDirector)
        {
            dialog.gameObject.SetActive(true);
        }

    }

    void OnEnable()
    {
        director.stopped += OnPlayableDirectorStopped;
    }

    void OnDisable()
    {
        director.stopped -= OnPlayableDirectorStopped;
    }


}
