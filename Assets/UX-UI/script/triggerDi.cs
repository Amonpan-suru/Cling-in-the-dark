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
    public float di;
    public float diback;

    private void Update()
    {
        float dist = Vector3.Distance(transform.position, player.transform.position);

        if (dist < 2)
        {

            me.gameObject.SetActive(true);
            other.gameObject.SetActive(false);
            other2.gameObject.SetActive(false);
            TriggerDialogue();
            Destroy(gameObject);
        }       
            
    }
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
