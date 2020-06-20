using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class directorstop : MonoBehaviour
{
    public PlayableDirector director;
    public GameObject dialog;
    public GameObject timeline;

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

    
    // Update is called once per frame
    void Update()
    {
        PlayableDirector pd = timeline.GetComponent<PlayableDirector>();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pd.Play();
        }
    }

    
}
