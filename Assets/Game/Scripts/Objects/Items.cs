using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public static bool Camera = false;
    public static bool Photo01 = false;
    public static bool Photo02 = false;
    public static bool Photo03 = false;
    public static bool Photo04 = false;
    public static bool Photo05 = false;
    public static bool Photo06 = false;
    public static bool Photo07 = false;

    public static void PickUpCamera()
    {
        Camera = true;
        FMODUnity.RuntimeManager.PlayOneShot("event:/Interactables/equip_camera");
    }

}
