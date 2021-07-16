using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSound : MonoBehaviour
{
    private static FMOD.Studio.EventInstance rainS;
    // Start is called before the first frame update
    void Start()
    {
        rainS = FMODUnity.RuntimeManager.CreateInstance("event:/Ambience/Rain");
        rainS.start();
        rainS.release();
    }

    // Update is called once per frame
    void Update()
    {
        rainS.setParameterByName("Rain", 0f);
        if (!Weather.isRaining)
        {
            rainS.setParameterByName("Rain", 1f);
            rainS.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        }
    }
}
