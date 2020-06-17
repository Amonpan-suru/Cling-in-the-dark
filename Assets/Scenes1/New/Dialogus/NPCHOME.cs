using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCHOME : MonoBehaviour
{
    public Dialogue dialogue;

    public float timer = 0;

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "player")
        {
            timer += Time.deltaTime;

            if (timer >= 5 && timer <=5.2f)
            {
                TriggerDialogue();
                
            }
        }
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
