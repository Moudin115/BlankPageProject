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

    private int Reputation_Jan;
    private int Reputation_Mom;
    private int Reputation_Joe;

    public GameObject JanObj;
    public GameObject MomObj;
    public GameObject JoeObj;

    public float movespeeds;

    public GameObject tarJan;
    public GameObject tarMom;
    public GameObject tarJoe;

    public GameObject player;

    private static FMOD.Studio.EventInstance TrainS;

    private void Start()
    {
        TrainS = FMODUnity.RuntimeManager.CreateInstance("event:/Ambience/train");
        TrainS.start();
        TrainS.release();

        dialogueRunner = FindObjectOfType<DialogueRunner>();
        Reputation_Jan = GameStatus.Rep_Jan;
        //Reputation_Mom = GameStatus.Rep_Mom;
        Reputation_Joe = GameStatus.Rep_Joe;

        Reputation_Mom = 1;

        TrainS.setParameterByName("TrainLeaving", 0f);


    }
    private void Update()
    {
        
        if (Trig == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                player.transform.localScale = new Vector3(1, 1, 1);
                TrainS.setParameterByName("TrainLeaving", 1f);
                Trig = false;
                CheckReps();
                CheckJan();
                CheckMom();
                CheckJoe();
            }
        }
        if (EndDialogue && dialogueRunner.IsDialogueRunning == false)
        {
            SceneManager.LoadScene("EndingScreen");
            TrainS.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
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
            dialogueRunner.StartDialogue("alone");
            EndDialogue = true;
        }
    }
    void CheckJan()
    {
        if (Reputation_Jan >= 3)
        {
            End.jan = true;
            JanObj.SetActive(true);
            JanObj.transform.position = tarJan.transform.position;
            dialogueRunner.StartDialogue("Jan");
            EndDialogue = true;
        }
    }
    void CheckMom()
    {
        if (Reputation_Mom > 0)
        {
            End.mom = true;
            MomObj.SetActive(true);
            MomObj.transform.position = tarMom.transform.position;
            dialogueRunner.StartDialogue("mom");
            EndDialogue = true;
        }
    }
    void CheckJoe()
    {
        if (Reputation_Joe >= 2)
        {
            End.joe = true;
            JoeObj.SetActive(true);
            JoeObj.transform.position = Vector2.MoveTowards(JoeObj.transform.position, tarJoe.transform.position, movespeeds * Time.deltaTime);
            JoeObj.transform.position = tarJoe.transform.position;
            dialogueRunner.StartDialogue("alone");
            EndDialogue = true;
        }
    }
}
