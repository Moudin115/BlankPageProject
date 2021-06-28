using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    public Transform cam;
    public float relativeMove = .3f;
    public bool lockY = false;

    void Update()
    {
            if (lockY)
            {
                transform.position = new Vector3(cam.position.x * relativeMove, transform.position.y, transform.position.z);
            }
            else
            {
                transform.position = new Vector3(cam.position.x * relativeMove, cam.position.y * relativeMove, transform.position.z);
            }

    }
}
