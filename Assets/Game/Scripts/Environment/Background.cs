using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector2(player.transform.position.x, 1.5f) ;
    }
}
