using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class TrainDialogue : MonoBehaviour
{
    private bool TriggerTrig = false;
    private DialogueRunner dialogueRunner;
    public string DialogueName = "";

    public static FMOD.Studio.EventInstance TrainS;

    public GameObject End;

    public Animator Anim;

    private void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
        TrainS = FMODUnity.RuntimeManager.CreateInstance("event:/Ambience/train");
        TrainS.start();
        TrainS.release();

    }
    private void Update()
    {
        if (TriggerTrig == true)
        {
            TrainS.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        }
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
