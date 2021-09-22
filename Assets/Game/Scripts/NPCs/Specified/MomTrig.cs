using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class MomTrig : MonoBehaviour
{
    public GameObject Mom;
    public GameObject MomCouch;
    public GameObject Door;
    private DialogueRunner dialogueRunner;
    public string DialogueName = "Start";

    public static bool MomDialogue = false;

    

    private void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
        if (MomDialogue == true)
        {
            MomCouch.SetActive(true);
        }
        if (MomDialogue == false)
        {
            MomCouch.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (PackTrig.hasPacked == true && MomDialogue == false)
        {
            Destroy(Door);
            MomCouch.SetActive(true);
            //Mom.SetActive(true);
            dialogueRunner.StartDialogue(DialogueName);
            MomDialogue = true;
        }
        Door.SetActive(true);
    }
}
