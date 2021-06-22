using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraHandler : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject PolaroidCam;
    public GameObject PolaroidMenu;
    public GameObject Blend;

    public Camera Polaroidcamera;
    public float speed;

    public GameObject Trigger;

    public static bool PolaroidCamActive;

    public Animator BlendAnim;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && PolaroidRestrictionArea.isInCol == true)
        {
            playerMovement.StopMovement = true;
            PolaroidCam.SetActive(true);
            PolaroidCamActive = true;
            PolaroidMenu.SetActive(true);
            mainCam.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            playerMovement.StopMovement = false;
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
            Blend.SetActive(true);
            BlendAnim.SetTrigger("Start");
            //StartCoroutine(Waiter());
            //SceneManager.LoadScene(sceneName: "PhotoWall");
        }

        /*IEnumerator Waiter()
        {
            yield return new WaitForSecondsRealtime(5);
        }*/
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
