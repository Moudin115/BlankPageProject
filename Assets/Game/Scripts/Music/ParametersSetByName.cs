using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParametersSetByName : MonoBehaviour
{
    private static FMOD.Studio.EventInstance BGM ;
    private float SceneInstance;

    private void Start()
    {
        BGM = FMODUnity.RuntimeManager.CreateInstance("event:/BackgroundMusic/FritzisTheme");
        BGM.start();
        BGM.release();
    }
    private void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        switch (sceneName)
        {
            case "House_Fritzi_Room_Fritzi":
                SceneInstance = 0f;
                break;
            case "House_Fritzi":
                SceneInstance = 1f;
                break;
            case "Village":
                SceneInstance = 2f;
                break;
            case "Bakery":
                SceneInstance = 3f;
                break;
            case "Forest":
                SceneInstance = 2f;
                break;
            default:
                SceneInstance = 2f;
                break;
        }
        Progress(SceneInstance);
    }
    public void Progress(float SceneInstance)
    {
        BGM.setParameterByName("Village", SceneInstance);
    }
}
