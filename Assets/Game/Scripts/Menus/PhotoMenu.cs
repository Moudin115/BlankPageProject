using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhotoMenu : MonoBehaviour
{
    string lastScene = "Village";
    public GameObject Menu;

    public GameObject mainCam, PolaroidCam;
    // Start is called before the first frame update
    void Start()
    {
        PolaroidCam.SetActive(true);
        mainCam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(sceneName: lastScene);
        }
        if (Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown(KeyCode.S)|| Input.GetKeyDown(KeyCode.A)|| Input.GetKeyDown(KeyCode.D)|| Input.GetKeyDown(KeyCode.E))
        {
            Menu.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            ScreenshotHandler.TakeScreenshot_Static(500, 500);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Interactables/camera_trigger");
            mainCam.SetActive(true);
            PolaroidCam.SetActive(false);
            mainCam.SetActive(false);
            SceneManager.LoadScene(sceneName: "PhotoWall");
        }
    }
}
