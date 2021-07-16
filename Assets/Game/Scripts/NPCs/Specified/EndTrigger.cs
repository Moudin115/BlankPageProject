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

    public GameObject player;

    private static FMOD.Studio.EventInstance TrainS;

    private bool JanDia;
    private bool MomDia;
    private bool JoeDia;

    private static FMOD.Studio.EventInstance EndS;

    private void Start()
    {
        EndS = endMusicTrig.EndS;

        TrainS = FMODUnity.RuntimeManager.CreateInstance("event:/Ambience/train");
        TrainS.start();
        TrainS.release();

        dialogueRunner = FindObjectOfType<DialogueRunner>();
        Reputation_Jan = GameStatus.Rep_Jan;
        Reputation_Mom = GameStatus.Rep_Mom;
        Reputation_Joe = GameStatus.Rep_Joe;


        TrainS.setParameterByName("TrainLeaving", 0f);


    }
    private void Update()
    {
        
        if (Trig == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                    player.transform.localScale = new Vector3(1, 1, 1);
                CheckJan();
                CheckMom();
                CheckJoe();
                CheckReps();
                TrainS.setParameterByName("TrainLeaving", 1f);
                Trig = false;
                
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
            dialogueRunner.StartDialogue("enterTrainAlone");
            EndDialogue = true;
        }
        else
        {
            MultiDialogue();
        }
    }
    void MultiDialogue()
    {
        dialogueRunner.StartDialogue("Guests");
        EndDialogue = true;
    }
/*    void MomDial()
    {
        if (MomDia) dialogueRunner.StartDialogue("enterTrainGuestsMom");
        if (dialogueRunner.IsDialogueRunning == false)
        {
            JanDial();
        }
    }
    void JanDial()
    {
        if (JanDia) dialogueRunner.StartDialogue("enterTrainGuestsJan");
        if (dialogueRunner.IsDialogueRunning == false)
        {
            Dial2();
        }
    }
    void Dial2()
    {
        dialogueRunner.StartDialogue("enterTrainGuests2");
        if (dialogueRunner.IsDialogueRunning == false)
        {
            JoeDial();
        }
    }
    void JoeDial()
    {
        if (JoeDia) dialogueRunner.StartDialogue("enterTrainGuestsJoe");
        if (dialogueRunner.IsDialogueRunning == false)
        {
            dialogueRunner.StartDialogue("enterTrainGuestsEnd");
            EndDialogue = true;
        }
    }
*/
    void CheckJan()
    {
        if (Reputation_Jan >= 3)
        {
            EndS.setParameterByName("JanEnding", 1f);
            End.jan = true;
            JanDia = true;
            EndDialogue = true;
        }
    }
    void CheckMom()
    {
        if (Reputation_Mom > 0)
        {
            EndS.setParameterByName("Mom", 1f);
            End.mom = true;
            MomDia = true;
            EndDialogue = true;
        }
    }
    void CheckJoe()
    {
        if (Reputation_Joe >= 2)
        {
            EndS.setParameterByName("Joe", 1f);
            End.joe = true;
            JoeDia = true;
            EndDialogue = true;
        }
    }
}
