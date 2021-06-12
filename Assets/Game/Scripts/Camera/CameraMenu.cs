using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CameraMenu : MonoBehaviour
{
    public string prevScene;

    public GameObject photoMenu;
    public GameObject whiteBlend;


    private void Start()
    {
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            photoMenu.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                
                photoMenu.SetActive(false);
                whiteBlend.SetActive(true);
                for (byte i = 255; i == 0; i--)
                {
                    whiteBlend.GetComponent<Image>().color = new Color32(255, 255, 255, i);
                    Debug.Log("Test");
                }
            }

        }
        else
        {
            photoMenu.SetActive(false);
            whiteBlend.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(prevScene);
        }
        
    }
}
