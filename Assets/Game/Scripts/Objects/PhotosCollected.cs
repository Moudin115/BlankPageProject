using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PhotosCollected : MonoBehaviour
{
    public static int currentPhotos = 0;
    public int maxPhotos = 10;
    public TextMeshProUGUI photosText;


    public void SetPhotos(int photos)
    {
        photosText.text = photos.ToString();
    }


}
