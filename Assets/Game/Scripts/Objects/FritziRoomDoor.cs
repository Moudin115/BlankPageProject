using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FritziRoomDoor : MonoBehaviour
{
    public GameObject ExitTrigger;
    public GameObject DoorDialogue;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Items.Camera == true)
        {
            ExitTrigger.SetActive(true);
            DoorDialogue.SetActive(false);
        }
    }
}
