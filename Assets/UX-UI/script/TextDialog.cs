using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextDialog : MonoBehaviour
{
    public Text Dialog;
    public string[] sentence;
    private int index;
    public float typespeed;
    private AudioSource SFXclick;
    public Animator fade;

    void Start()
    {
        SFXclick = GetComponent<AudioSource>();
        StartCoroutine(Type());
        
    }

    IEnumerator Type()
    {
        foreach (char letter in sentence[index].ToCharArray())
        {
            Dialog.text += letter;
            yield return new WaitForSeconds(typespeed);

        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SFXclick.Play();
            if (index < sentence.Length-1)
            {
                index++;
                Dialog.text = "";
                StartCoroutine(Type());
            }
            else
            {
                Dialog.text = "";
                fade.SetTrigger("fade");
            }
        }
    }
}
