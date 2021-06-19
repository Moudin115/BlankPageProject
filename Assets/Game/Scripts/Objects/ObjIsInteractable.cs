using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjIsInteractable : MonoBehaviour
{
    public static bool isInteractable = false;
    public GameObject Outline;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            isInteractable = true;
            Outline.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            isInteractable = false;
            Outline.SetActive(false);
        }
    }

}
