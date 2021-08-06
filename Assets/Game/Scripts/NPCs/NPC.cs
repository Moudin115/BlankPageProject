using UnityEngine;

/// attached to the non-player characters, and stores the name of the Yarn
/// node that should be run when you talk to them.
public class NPC : MonoBehaviour
{

    public string characterName = "";

    public static NPC ActiveNPC { get; private set; }
    public string YarnStartNode { get { return talkToNode; } }

    public string talkToNode = "Start";
    public bool playerDetected;
    [SerializeField] YarnProgram yarnDialog;

    void Start()
    {
        
        if (yarnDialog != null)
        {
            Yarn.Unity.DialogueRunner dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
            //dialogueRunner.StartDialogue("Start");
            dialogueRunner.Add(yarnDialog);
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.tag == "Player")
            {
            SetActiveNPC(true);
            playerDetected = true;
            }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SetActiveNPC(false);
            playerDetected = false;
        }

    }
    private void Update()
    {
        
        Yarn.Unity.DialogueRunner dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
        if (playerDetected && Input.GetButtonDown("Interact")) {
            playerDetected = false;
            dialogueRunner.StartDialogue(talkToNode);
            if (talkToNode == "PickUpCamera")
            {
                Items.PickUpCamera();
                Destroy(gameObject);
            }
            if (characterName == "Jan") {
                talkToNode = "default";
            }
        }
    }

    void SetActiveNPC(bool set)
    {
        ActiveNPC = set ? this : null;
    }
}