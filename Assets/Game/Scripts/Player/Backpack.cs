using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backpack : MonoBehaviour
{
    public GameObject BackPack;


    void Update()
    {
        if (Items.Luggage == true)
        {
            BackPack.SetActive(true);
        }
    }
}
