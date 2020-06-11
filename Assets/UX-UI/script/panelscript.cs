using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class panelscript : MonoBehaviour
{
    public GameObject panelmain;
    public GameObject panelchapter;
    public GameObject paneloption;
    public GameObject panelcradit;
    public GameObject panelslfe;
    public void PanelChapter(){

            panelchapter.gameObject.SetActive(true);
            panelmain.gameObject.SetActive(false);

}

public void Paneloption(){

            paneloption.gameObject.SetActive(true);
            panelmain.gameObject.SetActive(false);
    }     

public void Panelcredit(){

            panelcradit.gameObject.SetActive(true);
            panelmain.gameObject.SetActive(false);

    }


public void back(){

            panelslfe.gameObject.SetActive(false);
            panelmain.gameObject.SetActive(true);

    }

}

