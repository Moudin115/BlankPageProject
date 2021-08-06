using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDoor : MonoBehaviour
{
    public static bool endDoor = false;
    public static bool EndDoorActive = false;

    // Update is called once per frame
    void Update()
    {
        if (endDoor)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                EndDoorActive = true;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            endDoor = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        endDoor = false;
    }
}
