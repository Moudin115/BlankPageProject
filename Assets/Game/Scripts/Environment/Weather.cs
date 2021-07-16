using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weather : MonoBehaviour
{

    

    public static bool isRaining = false;
    public GameObject rain;
    private void Start()
    {
        

    }
    void Update()
    {
        
        if (isRaining == true)
        {
            rain.SetActive(true);
            
        }
        if (isRaining == false)
        {
            rain.SetActive(false);
            
        }
        
    }

}
