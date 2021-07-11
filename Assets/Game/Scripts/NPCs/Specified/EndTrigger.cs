using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    private DialogueRunner dialogueRunner;

    public static bool Trig;
    public static bool EndDialogue;

    public int Reputation_Jan = GameStatus.Rep_Jan;
    public int Reputation_Mom = GameStatus.Rep_Mom;
    public int Reputation_Joe = GameStatus.Rep_Joe;

    private void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
    }

    private void Update()
    {
        if (Trig == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Trig = false;
                CheckReps();            }
        }
        if (EndDialogue && dialogueRunner.IsDialogueRunning == false)
        {
            SceneManager.LoadScene("EndingScreen");
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
    void CheckReps()
    {
        if (Reputation_Jan < 3 && Reputation_Mom == 0 && Reputation_Joe < 2)
        {
            End.alone = true;
            dialogueRunner.StartDialogue("alone");
            EndDialogue = true;
            
        }
        if (Reputation_Jan >= 3)
        {
            End.jan = true;
            dialogueRunner.StartDialogue("alone");
            EndDialogue = true;
        }
        if (Reputation_Mom > 0)
        {
            End.mom = true;
            dialogueRunner.StartDialogue("alone");
            EndDialogue = true;
        }
        if (Reputation_Joe >= 2)
        {
            End.joe = true;
            dialogueRunner.StartDialogue("alone");
            EndDialogue = true;
        }
    }

}
