using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    // Start is called before the first frame update
    void Start()
    {
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

                float mouseWheel = Input.GetAxis("Mouse ScrollWheel");
                if (mouseWheel != 0 && Spaced == false)
                {
                    Polaroidcam.orthographicSize -= mouseWheel;
                }
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    FMODUnity.RuntimeManager.PlayOneShot("event:/Interactables/camera_trigger");
                    //ScreenshotHandler.TakeScreenshot_Static(500, 500);
                    Blend.SetActive(true);
                    BlendAnim.SetTrigger("Start");
                    Items.Photo01 = true;
                    Polaroid.SetActive(true);
                    PolaroidAnim.SetTrigger("Start");
                    Spaced = true;
                }
            }
        }
    }
    public void Confirm()
    {
            SceneManager.LoadScene(sceneName: lastScene);
    }
}
