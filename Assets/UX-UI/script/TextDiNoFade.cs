using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class TextDiNoFade : MonoBehaviour
{
    public GameObject me;
    public GameObject bgme;

    public GameObject other;
    public GameObject bgother;

    public Text Dialog;
    public string[] sentence;
    private int index;
    private AudioSource SFXclick;
    public GameObject dialognext;
    public GameObject bgtext;


    void Start()
    {
        bgtext.gameObject.SetActive(true);
        me.gameObject.SetActive(true);
        bgme.gameObject.SetActive(true);
        other.gameObject.SetActive(false);
        bgother.gameObject.SetActive(false);

        SFXclick = GetComponent<AudioSource>();
        StartCoroutine(Type());
    }


    IEnumerator Type()
    {
        foreach (char letter in sentence[index].ToCharArray())
        {
            Dialog.text += letter;
            yield return new WaitForSeconds(0.03f);

        }
    }

    private void Update()
    {

        if (Dialog.text == sentence[index])
        {
            if (Input.GetKeyDown(KeyCode.Space))
        {
            SFXclick.Play();
                if (index < sentence.Length - 1)
                {
                    index++;
                    Dialog.text = "";
                    StartCoroutine(Type());
                }
                else
                {
                    Dialog.text = "";

                    dialognext.gameObject.SetActive(true);
                    Destroy(gameObject);

                }
            }
        }
    }
}
