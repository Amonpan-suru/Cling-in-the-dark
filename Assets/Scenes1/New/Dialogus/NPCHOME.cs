using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCHOME : MonoBehaviour
{

    public GameObject me;


    public float timer = 0;

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "player")
        {
            timer += Time.deltaTime;

            if (timer >= 5 && timer <=5.2f)
            {
                me.gameObject.SetActive(true);
                
                
            }
        }
    }
}
