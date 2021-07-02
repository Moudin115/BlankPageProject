using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class DialogueTrigger : MonoBehaviour
{
    private static bool TriggerTrig = false;
    private DialogueRunner dialogueRunner;

        private void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (TriggerTrig == false)
            {
                dialogueRunner.StartDialogue();
                TriggerTrig = true;
            }
        }
    }
}
