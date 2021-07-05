using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraHandler : MonoBehaviour
{




    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (PolaroidRestrictionArea.isInCol) SceneManager.LoadScene("Photo_01");
            if (PolaroidRestrictionArea.isInCol02) SceneManager.LoadScene("Photo_02");
            if (PolaroidRestrictionArea.isInCol03) SceneManager.LoadScene("Photo_03");
            if (PolaroidRestrictionArea.isInCol04) SceneManager.LoadScene("Photo_04");
            if (PolaroidRestrictionArea.isInCol05) SceneManager.LoadScene("Photo_05");
            if (PolaroidRestrictionArea.isInCol06) SceneManager.LoadScene("Photo_06");
            if (PolaroidRestrictionArea.isInCol07) SceneManager.LoadScene("Photo_07");

        }
            /*if (Input.GetKeyDown(KeyCode.F) && PolaroidRestrictionArea.isInCol == true)
        {
            SceneManager.LoadScene(sceneName: "Photo_01");
            playerMovement.StopMovement = true;
            PolaroidRestrictionArea.walkStop = true;
            PolaroidCam.SetActive(true);
            PolaroidCamActive = true;
            PolaroidMenu.SetActive(true);
            mainCam.SetActive(false);
            
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            
            playerMovement.StopMovement = false;
            PolaroidRestrictionArea.walkStop = false;
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
            FMODUnity.RuntimeManager.PlayOneShot("event:/Interactables/camera_trigger");
            Blend.SetActive(true);
            BlendAnim.SetTrigger("Start");
            //StartCoroutine(Waiter());
            SceneManager.LoadScene(sceneName: "PhotoWall");*/
        //}

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
