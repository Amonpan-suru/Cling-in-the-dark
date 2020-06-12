using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDecrease : MonoBehaviour
{
    public Light Light1;

    private void OnTriggerEnter(Collider collision)
    {
        if( collision.gameObject.tag == "DarkHand" )
        {
            Light1.intensity -= 0.5f;
        }
    }
}
