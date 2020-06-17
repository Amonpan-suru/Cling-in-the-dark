using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnFX : MonoBehaviour
{
   public AudioSource Mybtn;
   public AudioClip hover;
   public AudioClip click;

    public void HoverFX(){
        Mybtn.PlayOneShot(hover);
    }

    public void ClickFX(){
        Mybtn.PlayOneShot(click);
    }

}
