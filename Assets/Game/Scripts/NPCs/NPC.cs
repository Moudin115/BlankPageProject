using UnityEngine;

/// attached to the non-player characters, and stores the name of the Yarn
/// node that should be run when you talk to them.
public class NPC : MonoBehaviour
{

    public string characterName = "";

    public string talkToNode = "";
    public bool playerDetected;

    [Header("Optional")]
    public YarnProgram scriptToLoad;

    void Start()
    {
        if (scriptToLoad != null)
        {
            Yarn.Unity.DialogueRunner dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
            dialogueRunner.Add(scriptToLoad);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.tag == "Player")
            {
                 playerDetected = true;
            }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerDetected = false;
        }

    }
    private void Update()
    {
        if (playerDetected && Input.GetKeyDown(KeyCode.E)) {
            playerDetected = false;
            Yarn.Unity.DialogueRunner dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
            dialogueRunner.StartDialogue();
        }
    }
}