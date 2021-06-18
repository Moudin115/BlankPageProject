using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamDestroyer : MonoBehaviour
{

    void Start()
    {
        if (Items.Camera == true)
        {
            Destroy(gameObject);
        }
    }

}
