using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class PhotoMenu : MonoBehaviour
{
    public string lastScene = "";
    public GameObject Menu;

    public Camera Polaroidcam;
    public float speed = 1;

    private bool EisPressed = false;

    public GameObject Blend;
    public Animator BlendAnim;

    public GameObject Polaroid;
    public Animator PolaroidAnim;

    private bool Spaced;

    public string PhotoNr;
    

    // Start is called before the first frame update
    void Start()
    {
        PolaroidRestrictionArea.isInCol = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (!Spaced)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                SceneManager.LoadScene(sceneName: lastScene);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                Menu.SetActive(false);
                EisPressed = true;
            }
            if (EisPressed)
            {
                float horz = Input.GetAxis("Horizontal");
                float vert = Input.GetAxis("Vertical");

                
                Polaroidcam.transform.position += (Vector3.up * vert + Vector3.right * horz) * speed * Time.deltaTime;
                if (Polaroidcam.transform.position.x >= 2.85f) { Polaroidcam.transform.position = new Vector3(2.85f, Polaroidcam.transform.position.y,  Polaroidcam.transform.position.z); }
                if (Polaroidcam.transform.position.x <= -2.85f) { Polaroidcam.transform.position = new Vector3(-2.85f, Polaroidcam.transform.position.y,  Polaroidcam.transform.position.z); }
                if (Polaroidcam.transform.position.y >= 2.07f) { Polaroidcam.transform.position = new Vector3(  Polaroidcam.transform.position.x, 2.07f, Polaroidcam.transform.position.z); }
                if (Polaroidcam.transform.position.y <= -2.07f) { Polaroidcam.transform.position = new Vector3( Polaroidcam.transform.position.x, -2.07f, Polaroidcam.transform.position.z); }


                float mouseWheel = Input.GetAxis("Mouse ScrollWheel");
                if (mouseWheel != 0 && Spaced == false)
                {
                    Polaroidcam.orthographicSize -= mouseWheel;
                    if (Polaroidcam.orthographicSize >= 4)
                    {
                        Polaroidcam.orthographicSize = 4;
                    }
                    if (Polaroidcam.orthographicSize <= 0.5f)
                    {
                        Polaroidcam.orthographicSize = 0.5f;
                    }


                }
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    FMODUnity.RuntimeManager.PlayOneShot("event:/Interactables/camera_trigger");
                    ScreenshotHandler.TakeScreenshot_Static(500, 500);
                    Blend.SetActive(true);
                    BlendAnim.SetTrigger("Start");
                    Items.Photo01 = true;
                    Polaroid.SetActive(true);
                    PolaroidAnim.SetTrigger("Start");
                    Spaced = true;
                    Yarn.Unity.DialogueRunner dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
                    PlayerVariables.currentPics -= 1;
                    int Photos = PlayerVariables.currentPics;
                    switch (Photos)
                    {
                        case 6:
                            dialogueRunner.StartDialogue("6Left");
                            break;
                        case 5:
                            dialogueRunner.StartDialogue("5Left");
                            break;
                        case 4:
                            dialogueRunner.StartDialogue("4Left");
                            break;
                        case 3:
                            dialogueRunner.StartDialogue("3Left");
                            break;
                        case 2:
                            dialogueRunner.StartDialogue("2Left");
                            break;
                        case 1:
                            dialogueRunner.StartDialogue("1Left");
                            break;
                        case 0:
                            dialogueRunner.StartDialogue("0Left");
                            break;
                    }
                }
            }
        }
    }
    public void Confirm()
    {
        SceneManager.LoadScene(sceneName: lastScene);
    }
}
