using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakeryBell : MonoBehaviour
{
    void Start()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Interactables/bakery_bell");
    }
}
