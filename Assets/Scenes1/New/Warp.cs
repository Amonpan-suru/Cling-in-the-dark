using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
    public GameObject player;
    public GameObject player1;
    public GameObject target;
    
    int ID = 0;
    void Start()
    {
        ID = 0;
        
    }
    
    void Update()
    {

        float dist = Vector3.Distance (transform.position, player.transform.position);
            if(dist < 1f)
        {
            if (Input.GetKeyDown(KeyCode.F) && ID == 1 )
            {
                
                player.transform.position = target.transform.position;
                player1.transform.rotation = Quaternion.Euler(0f, 180, 0f);
                move.rotate = 1f;

            }
            ID = 1;
            
        }
        else
        {
            ID = 0;
        }
    }
    

}

