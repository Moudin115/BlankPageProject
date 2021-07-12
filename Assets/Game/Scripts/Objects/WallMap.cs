using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class WallMap : MonoBehaviour
{

    private DialogueRunner dialogueRunner;

    private void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
    }


    public void MapDialogue()
    {
        dialogueRunner.StartDialogue("LookAtPostcard");
    }
}
