using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weather : MonoBehaviour
{

    private static FMOD.Studio.EventInstance rainS;
    private float AmbienceInstance;

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
            AmbienceInstance = 1f;
            rain.SetActive(true);
            Ambiencer(AmbienceInstance);
        }
        if (isRaining == false)
        {
            AmbienceInstance = 0f;
            rain.SetActive(false);
            Ambiencer(AmbienceInstance);
        }
        
    }

    public void Ambiencer(float AmbienceInstance)
    {
        rainS.setParameterByName("Rain", AmbienceInstance);
    }
}
