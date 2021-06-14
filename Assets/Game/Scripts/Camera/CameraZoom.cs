using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public Camera Polaroidcam;
    public float speed;


    private void Start()
    {
    }

    public void Update()
    {
        /*if ( Input.GetKeyDown(KeyCode.Z))
        {
            Polaroidcam.orthographicSize = Mathf.Lerp(Polaroidcam.orthographicSize, 1, speed);
        }
        else
        {
            Polaroidcam.orthographicSize = Mathf.Lerp(Polaroidcam.orthographicSize, 3, speed);
        }*/
    }
}
