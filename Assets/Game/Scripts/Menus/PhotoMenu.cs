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

    public int PhotoNr;
    private bool CanPic;

    SceneSwitch sceneSwitch;


    // Start is called before the first frame update
    void Start()
    {
        PolaroidRestrictionArea.isInCol = false;
        PolaroidRestrictionArea.isInCol02 = false;
        PolaroidRestrictionArea.isInCol03 = false;
        PolaroidRestrictionArea.isInCol04 = false;
        PolaroidRestrictionArea.isInCol05 = false;
        PolaroidRestrictionArea.isInCol06 = false;
        PolaroidRestrictionArea.isInCol07 = false;

        sceneSwitch = FindObjectOfType<SceneSwitch>();

    }

    // Update is called once per frame
    void Update()
    {
        if (!Spaced)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                sceneSwitch.SwitchScene(lastScene);
            }
            if (Input.anyKeyDown)
            {
                Menu.SetActive(false);
                EisPressed = true;
            }

            if (EisPressed)
            {
                float horz = Input.GetAxis("Horizontal");
                float vert = Input.GetAxis("Vertical");
                Polaroidcam.transform.position += (Vector3.up * vert + Vector3.right * horz) * speed * Time.deltaTime;
                switch (PhotoNr)
                {
                    case 1:
                        if (Polaroidcam.transform.position.x >= 3.7f) { Polaroidcam.transform.position = new Vector3(3.7f, Polaroidcam.transform.position.y, Polaroidcam.transform.position.z); }
                        if (Polaroidcam.transform.position.x <= -3.7f) { Polaroidcam.transform.position = new Vector3(-3.7f, Polaroidcam.transform.position.y, Polaroidcam.transform.position.z); }
                        if (Polaroidcam.transform.position.y >= 1.37f) { Polaroidcam.transform.position = new Vector3(Polaroidcam.transform.position.x, 1.37f, Polaroidcam.transform.position.z); }
                        if (Polaroidcam.transform.position.y <= -1.37f) { Polaroidcam.transform.position = new Vector3(Polaroidcam.transform.position.x, -1.37f, Polaroidcam.transform.position.z); }
                        break;
                    case 2:
                        if (Polaroidcam.transform.position.x >= 3.74f) { Polaroidcam.transform.position = new Vector3(3.74f, Polaroidcam.transform.position.y, Polaroidcam.transform.position.z); }
                        if (Polaroidcam.transform.position.x <= -3.74f) { Polaroidcam.transform.position = new Vector3(-3.74f, Polaroidcam.transform.position.y, Polaroidcam.transform.position.z); }
                        if (Polaroidcam.transform.position.y >= 1.37f) { Polaroidcam.transform.position = new Vector3(Polaroidcam.transform.position.x, 1.37f, Polaroidcam.transform.position.z); }
                        if (Polaroidcam.transform.position.y <= -1.37f) { Polaroidcam.transform.position = new Vector3(Polaroidcam.transform.position.x, -1.37f, Polaroidcam.transform.position.z); }
                        break;
                        
                    case 3:
                        if (Polaroidcam.transform.position.x >= 3.74f) { Polaroidcam.transform.position = new Vector3(3.74f, Polaroidcam.transform.position.y, Polaroidcam.transform.position.z); }
                        if (Polaroidcam.transform.position.x <= -3.74f) { Polaroidcam.transform.position = new Vector3(-3.74f, Polaroidcam.transform.position.y, Polaroidcam.transform.position.z); }
                        if (Polaroidcam.transform.position.y >= 1.37f) { Polaroidcam.transform.position = new Vector3(Polaroidcam.transform.position.x, 1.37f, Polaroidcam.transform.position.z); }
                        if (Polaroidcam.transform.position.y <= -1.37f) { Polaroidcam.transform.position = new Vector3(Polaroidcam.transform.position.x, -1.37f, Polaroidcam.transform.position.z); }

                        break;
                    case 4:
                        if (Polaroidcam.transform.position.x >= 3.74f) { Polaroidcam.transform.position = new Vector3(3.74f, Polaroidcam.transform.position.y, Polaroidcam.transform.position.z); }
                        if (Polaroidcam.transform.position.x <= -3.74f) { Polaroidcam.transform.position = new Vector3(-3.74f, Polaroidcam.transform.position.y, Polaroidcam.transform.position.z); }
                        if (Polaroidcam.transform.position.y >= 1.37f) { Polaroidcam.transform.position = new Vector3(Polaroidcam.transform.position.x, 1.37f, Polaroidcam.transform.position.z); }
                        if (Polaroidcam.transform.position.y <= -1.37f) { Polaroidcam.transform.position = new Vector3(Polaroidcam.transform.position.x, -1.37f, Polaroidcam.transform.position.z); }
                        break;
                    case 5:
                        if (Polaroidcam.transform.position.x >= 3.74f) { Polaroidcam.transform.position = new Vector3(3.74f, Polaroidcam.transform.position.y, Polaroidcam.transform.position.z); }
                        if (Polaroidcam.transform.position.x <= -3.74f) { Polaroidcam.transform.position = new Vector3(-3.74f, Polaroidcam.transform.position.y, Polaroidcam.transform.position.z); }
                        if (Polaroidcam.transform.position.y >= 1.37f) { Polaroidcam.transform.position = new Vector3(Polaroidcam.transform.position.x, 1.37f, Polaroidcam.transform.position.z); }
                        if (Polaroidcam.transform.position.y <= -1.37f) { Polaroidcam.transform.position = new Vector3(Polaroidcam.transform.position.x, -1.37f, Polaroidcam.transform.position.z); }
                        break;
                    case 6:
                        if (Polaroidcam.transform.position.x >= 3.74f) { Polaroidcam.transform.position = new Vector3(3.74f, Polaroidcam.transform.position.y, Polaroidcam.transform.position.z); }
                        if (Polaroidcam.transform.position.x <= -3.74f) { Polaroidcam.transform.position = new Vector3(-3.74f, Polaroidcam.transform.position.y, Polaroidcam.transform.position.z); }
                        if (Polaroidcam.transform.position.y >= 1.37f) { Polaroidcam.transform.position = new Vector3(Polaroidcam.transform.position.x, 1.37f, Polaroidcam.transform.position.z); }
                        if (Polaroidcam.transform.position.y <= -1.37f) { Polaroidcam.transform.position = new Vector3(Polaroidcam.transform.position.x, -1.37f, Polaroidcam.transform.position.z); }
                        break;
                    case 7:
                        if (Polaroidcam.transform.position.x >= 3.74f) { Polaroidcam.transform.position = new Vector3(3.74f, Polaroidcam.transform.position.y, Polaroidcam.transform.position.z); }
                        if (Polaroidcam.transform.position.x <= -3.74f) { Polaroidcam.transform.position = new Vector3(-3.74f, Polaroidcam.transform.position.y, Polaroidcam.transform.position.z); }
                        if (Polaroidcam.transform.position.y >= 1.37f) { Polaroidcam.transform.position = new Vector3(Polaroidcam.transform.position.x, 1.37f, Polaroidcam.transform.position.z); }
                        if (Polaroidcam.transform.position.y <= -1.37f) { Polaroidcam.transform.position = new Vector3(Polaroidcam.transform.position.x, -1.37f, Polaroidcam.transform.position.z); }
                        break;
                }

                

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

                if (Input.GetKeyUp(KeyCode.E))
                {
                    CanPic = true;
                }
                    if (Input.GetKeyDown(KeyCode.E) && CanPic == true)
                    {
                        FMODUnity.RuntimeManager.PlayOneShot("event:/Interactables/camera_trigger");
                        ScreenshotHandler.TakeScreenshot_Static(300, 300);
                        Blend.SetActive(true);
                        BlendAnim.SetTrigger("Start");

                        switch (PhotoNr)
                        {
                            case 1:
                                Items.Photo01 = true;
                                break;
                            case 2:
                                Items.Photo02 = true;
                                break;
                            case 3:
                                Items.Photo03 = true;
                                break;
                            case 4:
                                Items.Photo04 = true;
                                break;
                            case 5:
                                Items.Photo05 = true;
                                break;
                            case 6:
                                Items.Photo06 = true;
                                break;
                            case 7:
                                Items.Photo07 = true;
                                break;
                        }
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
        sceneSwitch.SwitchScene(lastScene);
    }
}
