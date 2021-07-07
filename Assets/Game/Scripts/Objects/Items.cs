using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public static bool Camera;
    public static bool Photo01;
    public static bool Photo02;
    public static bool Photo03;
    public static bool Photo04;
    public static bool Photo05;
    public static bool Photo06;
    public static bool Photo07;

    public static void PickUpCamera()
    {
        Camera = true;
        FMODUnity.RuntimeManager.PlayOneShot("event:/Interactables/equip_camera");
    }

}
