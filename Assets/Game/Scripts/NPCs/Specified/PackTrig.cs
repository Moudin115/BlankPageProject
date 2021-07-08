using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackTrig : MonoBehaviour
{
    public static bool hasPacked;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            hasPacked = true;
        }
    }
}
