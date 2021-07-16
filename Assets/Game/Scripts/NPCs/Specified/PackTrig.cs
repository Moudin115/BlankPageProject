using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class PackTrig : MonoBehaviour
{
    public static bool hasPacked;

    public bool inCol;

    private DialogueRunner dialogueRunner;

    private void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
    }

    private void Update()
    {
        if (inCol)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                dialogueRunner.StartDialogue("PickupBackpack");
                hasPacked = true;
                Items.PickUpLuggage();
                Destroy(gameObject);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            inCol = true;
        }
    }
}
