using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    private Camera Cam;

    public bool useStaticBillboard;

    void Start()
    {
        Cam = Camera.main;
    }

    
    void LateUpdate()
    {
        if (!useStaticBillboard)
        {
            transform.LookAt(Cam.transform);
        }
        else
        {
            transform.rotation = Cam.transform.rotation;
        }


        transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y, 0f);
    }
}
