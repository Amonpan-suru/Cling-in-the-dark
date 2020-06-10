using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warp : MonoBehaviour
{
    public GameObject player;
    public GameObject playerModel;
    public GameObject target;

    public int ID = 0;
    
    void Start()
    {
        ID = 0;
    }

    void Update()
    {
        float dist = Vector3.Distance(transform.position, player.transform.position);

        if(dist < 1f)
        {
            if (Input.GetKeyDown(KeyCode.F) && ID == 1)
            {
                player.transform.position = target.transform.position;
                playerModel.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                StartCoroutine("coolDown");
            }
            ID = 1;
        }
        else
        {
            ID = 0;
        }
    }

    IEnumerator coolDown()
    {
        yield return new WaitForSeconds(1);
    }
}
