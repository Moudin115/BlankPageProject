using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerVariables : MonoBehaviour
{
    public int maxHealth = 20;
    public int currentHealth;

    public int maxPic = 10;
    public int currentPics;

    public CamBar camBar;
    public PhotosCollected photosCollected;

    private void Start()
    {

        currentHealth = maxHealth;
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
    
