using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloorMarker : MonoBehaviour
{
    public Text floormarker;

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "floor1")
        {
            floormarker.text = "floor1";
        }
        if (other.name == "floor2")
        {
            floormarker.text = "floor2";
        }
        if (other.name == "floor3")
        {
            floormarker.text = "floor3";
        }
        if (other.name == "floor4")
        {
            floormarker.text = "upperfloor";
        }
        if (other.name == "F3-4")
        {
            floormarker.text = "f3-4";
        }
        if (other.name == "F2-6")
        {
            floormarker.text = "f2-6";
        }
        if (other.name == "F2-3")
        {
            floormarker.text = "f2-3";
        }
        if (other.name == "F1-5")
        {
            floormarker.text = "f1-5";
        }
        if (other.name == "F3-1")
        {
            floormarker.text = "f3-1";
        }
    }
}
