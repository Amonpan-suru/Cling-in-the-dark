using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
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
            if (Input.GetKeyDown(KeyCode.F))
            {
                me.gameObject.SetActive(true);
                other.gameObject.SetActive(false);
                other2.gameObject.SetActive(false);
                TriggerDialogue();
                transform.rotation = Quaternion.Euler(0f, di, 0f);
            }
        }
        else
        {
            transform.rotation = Quaternion.Euler(0f, diback, 0f);
        }
    }
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }  
}
