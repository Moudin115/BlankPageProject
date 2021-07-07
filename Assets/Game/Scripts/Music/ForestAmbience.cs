using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForestAmbience : MonoBehaviour
{
    private static FMOD.Studio.EventInstance ambience;
    private float AmbienceInstance;

    private void Start()
    {
        ambience = FMODUnity.RuntimeManager.CreateInstance("event:/Ambience/AmbienceDay");
        ambience.start();
        ambience.release();
    }
    private void Update()
    {
        
        Ambiencer(AmbienceInstance);
    }
    public void Ambiencer(float AmbienceInstance)
    {
        ambience.setParameterByName("Location", AmbienceInstance);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            AmbienceInstance = 4f;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            AmbienceInstance = 3f;
        }
    }
}
