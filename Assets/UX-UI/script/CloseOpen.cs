using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CloseOpen : MonoBehaviour
{
    public GameObject Close;
    public GameObject Open;
    // Start is called before the first frame update
    void Start()
    {
        Close.gameObject.SetActive(false);
        Open.gameObject.SetActive(true);
    }

    // Update is called once per frame
    
}
