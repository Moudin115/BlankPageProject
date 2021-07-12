using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackTrig : MonoBehaviour
{
    public static bool hasPacked;

    public bool inCol;

    private void Update()
    {
        if (inCol)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                hasPacked = true;
                Items.PickUpLuggage();
                Destroy(gameObject);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            inCol = true;
        }
    }
}
