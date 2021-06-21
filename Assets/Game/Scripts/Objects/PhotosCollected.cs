using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PhotosCollected : MonoBehaviour
{
    public TextMeshProUGUI photosText;


    public void SetPhotos(int photos)
    {
        photosText.text = photos.ToString();
        //photosText.text = "only " + photos.ToString() + " pictures left!";
    }


}
