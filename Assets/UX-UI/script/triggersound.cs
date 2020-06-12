using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class triggersound : MonoBehaviour
{
public AudioSource crow;

// void Start()
//     {
//         crow = GetComponent<AudioSource>();
//     }
private void OnTriggerEnter(Collider other)
{
crow.mute = !crow.mute;
}
private void OnTriggerExit(Collider other){
crow.mute = !crow.mute;
}

}
