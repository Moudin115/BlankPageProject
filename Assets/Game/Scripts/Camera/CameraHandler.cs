using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject PolaroidCam;
    public GameObject PolaroidMenu;

    public Camera Polaroidcamera;
    public float speed;

    public GameObject Trigger;

    public static bool PolaroidCamActive;

    // Start is called before the first frame update
    void Start()
    {
        Trigger.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Time.timeScale = 0;
            PolaroidCam.SetActive(true);
            PolaroidCamActive = true;
            PolaroidMenu.SetActive(true);
            mainCam.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            Time.timeScale = 1;
            Trigger.SetActive(false);
            PolaroidCam.SetActive(false);
            PolaroidMenu.SetActive(false);
            PolaroidCamActive = false;
            mainCam.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Space) && PolaroidCamActive == true)
        {
            Trigger.SetActive(true);
            ScreenshotHandler.TakeScreenshot_Static(500, 500);
        }
        /*if (PolaroidCamActive == true)
        {
            if (Input.GetKey(KeyCode.Z))
            {
                Polaroidcamera.orthographicSize = Mathf.Lerp(Polaroidcamera.orthographicSize, 1, speed);
            }
            else
            {
                Polaroidcamera.orthographicSize = Mathf.Lerp(Polaroidcamera.orthographicSize, 3, speed);
            }
        }*/
    }


}
