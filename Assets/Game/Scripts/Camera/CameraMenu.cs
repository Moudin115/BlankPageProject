using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMenu : MonoBehaviour
{
    public GameObject photoMenu;
    public GameObject whiteBlend;

    public byte TP = 255;



    private void Start()
    {
        Color32 white = new Color32(255, 255, 255, TP);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            whiteBlend.SetActive(true);
            
        }
    }
}
