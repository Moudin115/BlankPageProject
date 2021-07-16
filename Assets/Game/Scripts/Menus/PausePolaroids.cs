using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePolaroids : MonoBehaviour
{

    public GameObject Pic01;
    public GameObject Pic02;
    public GameObject Pic03;
    public GameObject Pic04;
    public GameObject Pic05;

    void Update()
    {
        if (Items.Photo01 == true)
        {
            Pic01.SetActive(true);
        }
        if (Items.Photo02 == true)
        {
            Pic02.SetActive(true);
        }
        if (Items.Photo03 == true)
        {
            Pic03.SetActive(true);
        }
        if (Items.Photo04 == true)
        {
            Pic04.SetActive(true);
        }
        if (Items.Photo05 == true)
        {
            Pic05.SetActive(true);
        }
    }


}
