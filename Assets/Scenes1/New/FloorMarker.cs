using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloorMarker : MonoBehaviour
{
    public Text floormarker;

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Floor 1")
        {
            floormarker.text = "Floor 1";
        }
        if (other.name == "Floor 2")
        {
            floormarker.text = "Floor 2";
        }
        if (other.name == "Floor 3")
        {
            floormarker.text = "Floor 3";
        }
        if (other.name == "Floor 4")
        {
            floormarker.text = "UpperFloor";
        }
        if (other.name == "F3-4")
        {
            floormarker.text = "F3-4";
        }
        if (other.name == "F2-6")
        {
            floormarker.text = "F2-6";
        }
        if (other.name == "F2-3")
        {
            floormarker.text = "F2-3";
        }
        if (other.name == "F1-5")
        {
            floormarker.text = "F1-5";
        }
        if (other.name == "F3-1")
        {
            floormarker.text = "F3-1";
        }
    }
}
