using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParametersSetByName : MonoBehaviour
{
    FMOD.Studio.EventInstance Village;

    
    // Start is called before the first frame update
    void Start()
    {
        Village = FMODUnity.RuntimeManager.CreateInstance("event:/BackgroundMusic/FritzisTheme");

        Village.start();





        /*else
        {
            Village.setParameterByName("Village", 10f);
        }*/
    }
    private void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "House_Fritzi_Room_Fritzi")
        {
            Village.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            Village.setParameterByName("Village", 0f);
            Debug.Log(sceneName);
        }
        if (sceneName == "House_Fritzi")
        {
            Village.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            Village.setParameterByName("Village", 0f);
            Debug.Log(sceneName);
        }
        if (sceneName == "Village")
        {
            Village.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            Village.setParameterByName("Village", 10f);
            Debug.Log(sceneName);
            
        }
    }

}
