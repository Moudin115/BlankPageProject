using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Packing : MonoBehaviour
{
    public GameObject PackageTrigger;

    private bool Trig;

    private bool DialogueEnd;

    private DialogueRunner dialogueRunner;

    public Animator Anim;

    // Start is called before the first frame update
    private void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Trig && DialogueEnd == false && Jan.WalkCompleted == true)
        {
            //Anim.Play("Crossfade_End",0,0.25f);
            dialogueRunner.StartDialogue("DonePacking");
            PackageTrigger.SetActive(true);
            DialogueEnd = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Trig = true;
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Trig = false;
        }
    }
}
