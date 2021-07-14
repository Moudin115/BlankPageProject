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

    public GameObject JanObj;
    public GameObject MomObj;
    public GameObject JoeObj;

    private int Reputation_Jan;
    private int Reputation_Mom;
    private int Reputation_Joe;

    private void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();

        //Reputation_Jan = GameStatus.Rep_Jan;
        Reputation_Jan = GameStatus.Rep_Jan;
        Reputation_Mom = GameStatus.Rep_Mom;
        Reputation_Joe = GameStatus.Rep_Joe;
    }
    private void Update()
    {
        CheckJan();
        CheckMom();
        CheckJoe();
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
    void CheckJan()
    {
        if (Reputation_Jan >= 3)
        {
            JanObj.SetActive(true);
        }
    }
    void CheckMom()
    {
        if (Reputation_Mom > 0)
        {
            MomObj.SetActive(true);
        }
    }
    void CheckJoe()
    {
        if (Reputation_Joe >= 2)
        {
            JoeObj.SetActive(true);
        }
    }
}
