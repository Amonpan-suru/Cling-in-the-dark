using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class read: MonoBehaviour
{
    public GameObject player;
    public Dialogue dialogue;


    private void start()
    {
        StartCoroutine(ExampleCoroutine());
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    } 

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(2);
        TriggerDialogue();
    } 
}
