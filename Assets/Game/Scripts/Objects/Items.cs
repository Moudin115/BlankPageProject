using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public static bool Camera = false;
    public static bool Photo01 = false;

    public static void PickUpCamera()
    {
        Camera = true;
        FMODUnity.RuntimeManager.PlayOneShot("event:/Interactables/equip_camera");
    }

}
