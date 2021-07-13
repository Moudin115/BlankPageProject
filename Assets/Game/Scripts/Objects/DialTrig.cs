using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class DialTrig : MonoBehaviour
{
    private bool TriggerTrig = false;
    private DialogueRunner dialogueRunner;
    public string DialogueName = "";

    

    private void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && TriggerTrig == false)
        {
            
            dialogueRunner.StartDialogue("Start");
            TriggerTrig = true;
        }
    }
}
