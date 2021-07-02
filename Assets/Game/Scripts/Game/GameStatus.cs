using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.UI;

public class GameStatus : MonoBehaviour
{
    //public AudioSource audioSource;

    public static int Rep_Jan = 20;
    public static int Rep_Mom = 20;
    public static int Rep_Joe = 20;

    public static int Pictures;


    private DialogueRunner dr;

    private void Start()
    {
        dr = FindObjectOfType<DialogueRunner>();
        //dr.AddCommandHandler("play_sound",PlaySound);
        dr.AddCommandHandler("Rep_Jan", ReputationJan);
        dr.AddCommandHandler("Rep_Mom", ReputationMom);
        dr.AddCommandHandler("Rep_Joe", ReputationJoe);
    }

    /*void PlaySound(string[] parameters)
    {
        audioSource.Play();
    }*/
    void ReputationJan(string[] parameters)
    {
        Rep_Jan += int.Parse(parameters[0]);
    }
    void ReputationMom(string[] parameters)
    {
        Rep_Mom += int.Parse(parameters[0]);
    }
    void ReputationJoe(string[] parameters)
    {
        Rep_Joe += int.Parse(parameters[0]);
    }
    private void Update()
    {
        
    }
}
