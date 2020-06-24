using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class fadeScript : MonoBehaviour
{
    public Animator transition;
    public float Time =1f;
    // Start is called before the first frame update
    void Update() 
    {

    }
public void LoadNextLevel(){
    StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex+1));
}
IEnumerator LoadLevel(int levelIndex){

    transition.SetTrigger("start");
    yield return new WaitForSeconds(Time);
    SceneManager.LoadScene(levelIndex);
}
}
