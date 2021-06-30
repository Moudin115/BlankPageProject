using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public Camera Polaroidcam;
    public float speed = 1;


    private void Start()
    {
    }

    public void Update()
    {
        float horz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        transform.position += (Vector3.up * vert + Vector3.right * horz)* speed * Time.deltaTime;

        float mouseWheel = Input.GetAxis("Mouse ScrollWheel");
        if(mouseWheel != 0)
        {
            Polaroidcam.orthographicSize -= mouseWheel;
        }
    }
}
