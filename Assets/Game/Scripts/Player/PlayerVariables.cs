using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerVariables : MonoBehaviour
{
    public int maxHealth = 20;
    public static int currentHealth = 20;

    public int maxPic = 10;
    public static int currentPics = 0;

    public CamBar camBar;

    public PhotosCollected photosCollected;

    private void Start()
    {
        camBar.SetHealth(currentHealth);
        photosCollected.SetPhotos(currentPics);
        transform.gameObject.GetComponentInChildren<Text>().text = currentHealth.ToString();
        camBar.SetMaxHealth(maxHealth);
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            TakePicture(1);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            RightPicture(1);
            TakePicture(1);
        }
    }

    void TakePicture(int picture)
    {
        currentHealth -= picture;

        camBar.SetHealth(currentHealth);
    }
    void RightPicture(int picture)
    {
        currentPics += picture;
        photosCollected.SetPhotos(currentPics);
    }
}
    
