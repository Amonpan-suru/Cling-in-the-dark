using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;
    public GameObject Camera4;
    public GameObject Camera5;
    public GameObject Camera6;
    public GameObject Camera7;
    public GameObject Camera8;
    public GameObject Camera9;
    public GameObject Camera10;

    private void OnTriggerStay(Collider other)
    {
        if(other.name == "MCRoomEscapeArea")
        {
            Camera1.SetActive(true);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Camera4.SetActive(false);
            Camera5.SetActive(false);
            Camera6.SetActive(false);
            Camera7.SetActive(false);
            Camera8.SetActive(false);
            Camera9.SetActive(false);
            Camera10.SetActive(false);
        }
        if(other.name == "KitchenEscapeArea")
        {
            Camera1.SetActive(false);
            Camera2.SetActive(true);
            Camera3.SetActive(false);
            Camera4.SetActive(false);
            Camera5.SetActive(false);
            Camera6.SetActive(false);
            Camera7.SetActive(false);
            Camera8.SetActive(false);
            Camera9.SetActive(false);
            Camera10.SetActive(false);
        }
        if(other.name == "EscapeArea")
        {
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(true);
            Camera4.SetActive(false);
            Camera5.SetActive(false);
            Camera6.SetActive(false);
            Camera7.SetActive(false);
            Camera8.SetActive(false);
            Camera9.SetActive(false);
            Camera10.SetActive(false);
        }
        if (other.name == "Floor1EscapeArea")
        {
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Camera4.SetActive(true);
            Camera5.SetActive(false);
            Camera6.SetActive(false);
            Camera7.SetActive(false);
            Camera8.SetActive(false);
            Camera9.SetActive(false);
            Camera10.SetActive(false);
        }
        if (other.name == "Floor2EscapeArea")
        {
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Camera4.SetActive(false);
            Camera5.SetActive(true);
            Camera6.SetActive(false);
            Camera7.SetActive(false);
            Camera8.SetActive(false);
            Camera9.SetActive(false);
            Camera10.SetActive(false);
        }
        if (other.name == "Floor3EscapeArea")
        {
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Camera4.SetActive(false);
            Camera5.SetActive(false);
            Camera6.SetActive(true);
            Camera7.SetActive(false);
            Camera8.SetActive(false);
            Camera9.SetActive(false);
            Camera10.SetActive(false);
        }
        if (other.name == "UpperFloorEscapeArea")
        {
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Camera4.SetActive(false);
            Camera5.SetActive(false);
            Camera6.SetActive(false);
            Camera7.SetActive(true);
            Camera8.SetActive(false);
            Camera9.SetActive(false);
            Camera10.SetActive(false);
        }
        if (other.name == "1-3_RoomArea")
        {
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Camera4.SetActive(false);
            Camera5.SetActive(false);
            Camera6.SetActive(false);
            Camera7.SetActive(false);
            Camera8.SetActive(true);
            Camera9.SetActive(false);
            Camera10.SetActive(false);
        }
        if (other.name == "2-6_RoomArea")
        {
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Camera4.SetActive(false);
            Camera5.SetActive(false);
            Camera6.SetActive(false);
            Camera7.SetActive(false);
            Camera8.SetActive(false);
            Camera9.SetActive(true);
            Camera10.SetActive(false);
        }
        if (other.name == "3-4_RoomArea")
        {
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Camera4.SetActive(false);
            Camera5.SetActive(false);
            Camera6.SetActive(false);
            Camera7.SetActive(false);
            Camera8.SetActive(false);
            Camera9.SetActive(false);
            Camera10.SetActive(true);
        }
    }
}
