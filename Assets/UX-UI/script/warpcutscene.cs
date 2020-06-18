using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class warpcutscene : MonoBehaviour
{
    public GameObject player;
    public GameObject player1;
    public string Scene;

    
    void Start()
    {

    }

    void Update()
    {

        float dist = Vector3.Distance(transform.position, player.transform.position);
        if (dist < 1f)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {

                SceneManager.LoadScene(Scene);

            }
           

        }

    }


}

