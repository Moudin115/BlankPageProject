using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ambience : MonoBehaviour
{
    private static FMOD.Studio.EventInstance ambience;
    private float AmbienceInstance;

    public bool Collided;

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
        switch (sceneName)
        {
            case "House_Fritzi_Room_Fritzi":
                AmbienceInstance = 0f;
                break;
            case "House_Fritzi":
                AmbienceInstance = 0f;
                break;
            case "Village":
                AmbienceInstance = 1f;
                break;
            case "Bakery":
                AmbienceInstance = 0f;
                break;
            case "Forest":
                if (Collided == false)
                {
                    AmbienceInstance = 3f;
                }
                if (Collided == true)
                {
                    AmbienceInstance = 4f;
                }
                break;
            default:
                AmbienceInstance = 0f;
                break;
        }
        Ambiencer(AmbienceInstance);
    }
    public void Ambiencer(float AmbienceInstance)
    {
        ambience.setParameterByName("Location", AmbienceInstance);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Collided = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Collided = false;
        }
    }
}