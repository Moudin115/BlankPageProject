using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class TrainDialogue : MonoBehaviour
{
    private bool TriggerTrig = false;
    private DialogueRunner dialogueRunner;
    public string DialogueName = "";

    public GameObject End;

    public Animator Anim;

    private void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && TriggerTrig == false)
        {
                dialogueRunner.StartDialogue(DialogueName);
            Anim.SetBool("TrainTrig", true);
            TriggerTrig = true;
                End.SetActive(true);
        }
    }
}
