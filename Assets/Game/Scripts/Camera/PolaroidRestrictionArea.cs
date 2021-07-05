using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolaroidRestrictionArea : MonoBehaviour
{

    public static bool isInCol;
    public static bool isInCol02;
    public static bool isInCol03;
    public static bool isInCol04;
    public static bool isInCol05;
    public static bool isInCol06;
    public static bool isInCol07;

    public int PhotoNR;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        switch (PhotoNR)
        {
            case 1:
                isInCol = true;
                break;
            case 2:
                isInCol02 = true;
                break;
            case 3:
                isInCol03 = true;
                break;
            case 4:
                isInCol04 = true;
                break;
            case 5:
                isInCol05 = true;
                break;
            case 6:
                isInCol06 = true;
                break;
            case 7:
                isInCol07 = true;
                break;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        isInCol = false;
        isInCol02 = false;
        isInCol03 = false;
        isInCol04 = false;
        isInCol05 = false;
        isInCol06 = false;
        isInCol07 = false;
    }
}
