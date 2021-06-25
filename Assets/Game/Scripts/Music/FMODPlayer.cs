using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class FMODPlayer : MonoBehaviour
{
    private float distance = 0.1f;
    private float Material;

    private void FixedUpdate()
    {
        MaterialCheck();
        Debug.DrawRay(transform.position, Vector2.down * distance, Color.blue);
    }

    void MaterialCheck()
    {
        RaycastHit2D hit;
        hit = Physics2D.Raycast(transform.position, Vector2.down, distance, 1 << 3);

        if (hit.collider)
        {
            if (hit.collider.tag == "Ground_Carpet")
            {
                Material = 0f;
            }
            else if (hit.collider.tag == "Ground_Concrete")
            {
                Material = 1f;
            }
            else if (hit.collider.tag == "Ground_LooseConcrete")
            {
                Material = 1f;
            }
            else
                Material = 0f;
        }

     }

    void PlayFootstepsEvent(string path)
    {
        FMOD.Studio.EventInstance Footsteps = FMODUnity.RuntimeManager.CreateInstance(path);
        Footsteps.setParameterByName("Surface", Material);
        Footsteps.start();
        Footsteps.release();
    }
}
