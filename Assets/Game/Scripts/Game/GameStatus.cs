using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.UI;

public class GameStatus : MonoBehaviour
{
    //public AudioSource audioSource;

    private DialogueRunner dr;

    public static int Rep_Jan = 0;
    public static int Rep_Mom = 0;
    public static int Rep_Joe = 0;

    public static int Pictures;

    public static int walker = 0;


    private void Start()
    {
        dr = FindObjectOfType<DialogueRunner>();
        //dr.AddCommandHandler("play_sound",PlaySound);
        dr.AddCommandHandler("Rep_Jan", ReputationJan);
        dr.AddCommandHandler("Rep_Mom", ReputationMom);
        dr.AddCommandHandler("Rep_Joe", ReputationJoe);

        dr.AddCommandHandler("Jan_Walk", Jan_Walk);
        dr.AddCommandHandler("end_Jan_Walk", end_Jan_Walk);

        dr.AddCommandHandler("weather_Rain", weather_Rain);
        dr.AddCommandHandler("weather_Sun", weather_Sun);

        dr.AddCommandHandler("sound_Cartridge", sound_Cartridge);
        dr.AddCommandHandler("sound_Photo", sound_Photo);

    }

    /*void PlaySound(string[] parameters)
    {
        audioSource.Play();
    }*/
    void ReputationJan(string[] parameters)
    {
        Rep_Jan += int.Parse(parameters[0]);
        Debug.Log(Rep_Jan);
    }
    void ReputationMom(string[] parameters)
    {
        Rep_Mom += int.Parse(parameters[0]);
        Debug.Log(Rep_Mom);
    }
    void ReputationJoe(string[] parameters)
    {
        Rep_Joe += int.Parse(parameters[0]);
        Debug.Log(Rep_Joe);
    }
    void Jan_Walk(string[] parameters)
    {
        Jan.Janwalk();
    }
    void end_Jan_Walk(string[] parameters)
    {
        Jan.endJanwalk();
    }

    void weather_Rain(string[] parameters)
    {
        Weather.isRaining = true;
    }
    void weather_Sun(string[] parameters)
    {
        Weather.isRaining = false;
    }
    void sound_Cartridge(string[] parameters)
    {
        FMOD.Studio.EventInstance S_Cartridge = FMODUnity.RuntimeManager.CreateInstance("event:/Interactables/camera_cartridge");
        S_Cartridge.start();
        S_Cartridge.release();
    }
    void sound_Photo(string[] parameters)
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Interactables/camera_trigger");
    }
}
