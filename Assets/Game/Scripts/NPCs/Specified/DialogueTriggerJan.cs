using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class DialogueTriggerJan : MonoBehaviour
{
    private static bool TriggerTrig = false;
    private DialogueRunner dialogueRunner;
    public string DialogueName = "";

    public static bool aboutTrig;

    private void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && TriggerTrig == false)
        {
            if (DialogueName == "Overlook")
            {
                dialogueRunner.StartDialogue(DialogueName);
                TriggerTrig = true;
            }
        }
    }
}
