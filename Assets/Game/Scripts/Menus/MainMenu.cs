using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static FMOD.Studio.EventInstance EndS;
    public static FMOD.Studio.EventInstance EndS2;
    public static FMOD.Studio.EventInstance BGM;

    private void Start()
    {
        EndS = FMODUnity.RuntimeManager.CreateInstance("event:/BackgroundMusic/MenuTheme");
        EndS.start();
        EndS.release();

        EndS2 = endMusicTrig.EndS;
        EndS2.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        BGM = ParametersSetByName.BGM;
    }
    private void Update()
    {
        //EndS.setParameterByName("EndingThemeLoop", 1f);
        BGM.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
    }
    public void PlayGame()
    {
        BGM.start();
        BGM.release();
        EndS.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void About()
    {
        EndS.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        SceneManager.LoadScene("Credits");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
