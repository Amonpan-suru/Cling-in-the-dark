using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerDi : MonoBehaviour
{
    public GameObject player;
    public Dialogue dialogue;
    public GameObject me;
    public GameObject other;
    public GameObject other2;

    private void OnTriggerEnter(Collider other)
    {
        me.gameObject.SetActive(true);
        other.gameObject.SetActive(false);
        other2.gameObject.SetActive(false);
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        Destroy(gameObject);
    }
}
