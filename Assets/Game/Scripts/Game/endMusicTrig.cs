using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endMusicTrig : MonoBehaviour
{
    public static FMOD.Studio.EventInstance EndS;
    public static FMOD.Studio.EventInstance BGM;

    // Start is called before the first frame update
    void Start()
    {
        EndS = FMODUnity.RuntimeManager.CreateInstance("event:/BackgroundMusic/EndingTheme");
        EndS.start();
        EndS.release();

        BGM = ParametersSetByName.BGM;
    }

    // Update is called once per frame
    void Update()
    {
        BGM.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        EndS.setParameterByName("EndingThemeLoop", 0f);
        EndS.setParameterByName("EndingThemeGuests", 0f);
    }
}
