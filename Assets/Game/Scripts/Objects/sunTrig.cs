using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class sunTrig : MonoBehaviour
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
        if (collision.tag == "Player" && TriggerTrig == false && Jan.WalkCompleted)
        {

            dialogueRunner.StartDialogue("sun");
            TriggerTrig = true;
        }
    }
}
