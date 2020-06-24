using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class nextTimeline : MonoBehaviour
{
    public GameObject timeline;
    void Update()
    {
        PlayableDirector pd = timeline.GetComponent<PlayableDirector>();
            pd.Play();
    }
}
