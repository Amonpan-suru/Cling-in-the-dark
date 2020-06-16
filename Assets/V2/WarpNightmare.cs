using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpNightmare : MonoBehaviour
{
    public GameObject Player;
    public GameObject Player1;
    public GameObject Target;
    public float test;

    int ID = 0;

    void Start()
    {
        ID = 0;
    }

    void Update()
    {   
        float Distance = Vector3.Distance(transform.position, Player.transform.position);
        test = Distance;

        if (Distance < 6.8f)
        {
            if (Input.GetKeyDown(KeyCode.F) && ID == 1)
            {
                Player.transform.position = Target.transform.position;
                Player1.transform.rotation = Quaternion.Euler(0f, 180, 0f);
                move.rotate = 0f;
            }
            ID = 1;

        }
        else
        {
            ID = 0;
        }
        
        //Debug.Log("Fuck");
    }
}