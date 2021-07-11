using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{

    public static bool alone;
    public static bool jan;
    public static bool mom;
    public static bool joe;

    public GameObject _alone;
    public GameObject _jan;
    public GameObject _joe;
    public GameObject _mom;


    // Update is called once per frame
    void Update()
    {
        if (alone == true) _alone.SetActive(true);
        if (jan == true) _jan.SetActive(true);
        if (joe == true) _joe.SetActive(true);
        if (mom == true) _mom.SetActive(true);

    }
}
