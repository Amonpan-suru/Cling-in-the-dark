using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class warpcutscene : MonoBehaviour
{
    public GameObject player;
    public GameObject player1;
    public GameObject fadein;
    public string Scene;

    

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(Scene);
    }

    void Update()
    {

        float dist = Vector3.Distance(transform.position, player.transform.position);
        if (dist < 1f)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                fadein.gameObject.SetActive(true);
                StartCoroutine(ExampleCoroutine());
                

            }
           

        }

    }


}

