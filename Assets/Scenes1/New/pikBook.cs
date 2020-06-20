using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pikBook : MonoBehaviour
{
    public GameObject player;
    public string Scene;

    private void Update()
    {
        float dist = Vector3.Distance(transform.position, player.transform.position);

        if(dist < 2)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                
                Destroy(gameObject);

                SceneManager.LoadScene(Scene);
            }
        }
    }
 
}
