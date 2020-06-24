using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    private Animator anime;

    private void Start()
    {
        anime = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            anime.SetBool("Walk", true);
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                anime.SetBool("Run", true);
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                anime.SetBool("Run", false);
            }
        }
        else
        {
            anime.SetBool("Walk", false);
            anime.SetBool("Run", false);
        }
       
        

    }
}
