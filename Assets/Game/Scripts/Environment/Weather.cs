using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weather : MonoBehaviour
{
    public static bool isRaining = false;
    public GameObject rain;
    void Update()
    {
        if (isRaining == true)
        {
            rain.SetActive(true);
        }
    }
}
