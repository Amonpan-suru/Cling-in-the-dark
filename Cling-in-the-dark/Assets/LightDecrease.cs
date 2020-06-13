using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDecrease : MonoBehaviour
{
    public Light Light1;
    public Component CameraMovement;
    public Component PlayerMovement;


    private void Start()
    {
        CameraMovement1 = gameObject.GetComponent<CameraMovement>();
        PlayerMovement1 = gameObject.GetComponent<PlayerMovement>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if( collision.gameObject.tag == "DarkHand" )
        {
            Light1.intensity -= 0.5f;
        }

        if( Light1.intensity == 0.0f )
        {
            CameraMovement.enabled = !CameraMovement.enabled;
            PlayerMovement.enabled = !PlayerMovement.enabled;           
        }
    }  
}
