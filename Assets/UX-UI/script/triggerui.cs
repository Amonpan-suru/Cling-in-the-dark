using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class triggerui : MonoBehaviour
{
public GameObject paneloption;
private void OnTriggerEnter(Collider other)
{
paneloption.gameObject.SetActive(true);
}
private void OnTriggerExit(Collider other){
paneloption.gameObject.SetActive(false);
}

}
