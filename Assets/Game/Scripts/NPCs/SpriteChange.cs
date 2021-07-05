using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{

    public GameObject camObj;

    // Update is called once per frame
    void Update()
    {
        if (Items.Camera == true)
        {
            camObj.SetActive(true);
        }
    }
}
