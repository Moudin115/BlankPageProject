using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerVariables : MonoBehaviour
{
    public int maxPic = 7;
    public static int currentPics = 7;

    public CamBar camBar;

    public PhotosCollected photosCollected;

    private void Start()
    {
        photosCollected.SetPhotos(currentPics);
       // transform.gameObject.GetComponentInChildren<Text>().text = currentHealth.ToString();
        
    }
    private void Update()
    {
        if (CameraHandler.PolaroidCamActive == true && Input.GetKeyDown(KeyCode.Space))
        {
            TakePicture(1);
        }
    }

    void TakePicture(int picture)
    {
        currentPics -= picture;
        photosCollected.SetPhotos(currentPics);
    }
}
    
