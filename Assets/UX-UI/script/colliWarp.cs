using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class colliWarp : MonoBehaviour
{
  
    public string scenename;
    public GameObject fadein;

    private void OnTriggerEnter(Collider other)
    {
        fadein.gameObject.SetActive(true);
        StartCoroutine(ExampleCoroutine());
    }

    private void start()
    {
        
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(scenename);
    }
}
