using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScene : MonoBehaviour
{
    public GameObject DayTime;
    public GameObject Evening;


    // Update is called once per frame
    void Update()
    {
        if (PackTrig.hasPacked == true)
        {
            DayTime.SetActive(false);
            Evening.SetActive(true);
        }
        if (PackTrig.hasPacked == false)
        {
            DayTime.SetActive(true);
            Evening.SetActive(false);
        }
    }
}
