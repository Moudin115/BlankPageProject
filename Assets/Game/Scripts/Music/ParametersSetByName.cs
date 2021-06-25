using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParametersSetByName : MonoBehaviour
{
    FMOD.Studio.EventInstance BGM = FMODUnity.RuntimeManager.CreateInstance("event:/BackgroundMusic/FritzisTheme");
    private void Start()
    {
        BGM.start();
    }
    private float SceneInstance;

    private void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "House_Fritzi_Room_Fritzi")
        {
            SceneInstance = 0f;
            BGM.setParameterByName("Village", SceneInstance);
            Debug.Log(sceneName);
        }
        if (sceneName == "House_Fritzi")
        {
            SceneInstance = 0f;
            BGM.setParameterByName("Village", SceneInstance);
            Debug.Log(sceneName);
        }
        if (sceneName == "Village")
        {
            SceneInstance = 10f;
            BGM.setParameterByName("Village", SceneInstance);
            Debug.Log(sceneName);
        }
        else
        {
            SceneInstance = 0f;
            BGM.setParameterByName("Village", SceneInstance);
        }
        
    }

}
