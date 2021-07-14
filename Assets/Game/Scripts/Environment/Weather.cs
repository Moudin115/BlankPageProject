using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weather : MonoBehaviour
{

    private static FMOD.Studio.EventInstance rainS;

    public static bool isRaining = false;
    public GameObject rain;
    private void Start()
    {
        rainS = FMODUnity.RuntimeManager.CreateInstance("event:/Ambience/Rain");
        rainS.start();
        rainS.release();
    }
    void Update()
    {
        
        if (isRaining == true)
        {
            rain.SetActive(true);
            rainS.setParameterByName("Rain", 0f);
        }
        if (isRaining == false)
        {
            rain.SetActive(false);
            rainS.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        }
        
    }

}
