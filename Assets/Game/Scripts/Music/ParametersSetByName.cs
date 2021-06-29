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
        if (sceneName == "House_Fritzi_Room_Fritzi")
        {
            SceneInstance = 0f;
        }
        if (sceneName == "House_Fritzi")
        {
            SceneInstance = 0f;
        }
        if (sceneName == "Village")
        {
            SceneInstance = 2f;
        }
        if (sceneName == "Bakery")
        {
            SceneInstance = 3f;
        }
        else
        {
            SceneInstance = 0f;
        }
        Progress(SceneInstance);
    }
    public void Progress(float SceneInstance)
    {
        BGM.setParameterByName("Village", SceneInstance);
    }
}
