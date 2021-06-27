using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ambience : MonoBehaviour
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
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "House_Fritzi_Room_Fritzi")
        {
            AmbienceInstance = 0f;
        }
        if (sceneName == "House_Fritzi")
        {
            AmbienceInstance = 0f;
        }
        if (sceneName == "Village")
        {
            AmbienceInstance = 1f;
        }
        else
        {
            AmbienceInstance = 0f;
        }
        Ambiencer(AmbienceInstance);
    }
    public void Ambiencer(float AmbienceInstance)
    {
        ambience.setParameterByName("Location", AmbienceInstance);
    }
}