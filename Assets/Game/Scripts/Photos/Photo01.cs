using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Photo01 : MonoBehaviour
{

    public GameObject PhotoCollider;
    public int PhotoNR;

    // Start is called before the first frame update
    void Start()
    {
        switch (PhotoNR) {
            case 1:
                if (Items.Photo01 == true)
                {
                    Destroy(PhotoCollider);
                    PhotoCollider.SetActive(false);
                }
                break;
            case 2:
                if (Items.Photo02 == true)
                {
                    Destroy(PhotoCollider);
                    PhotoCollider.SetActive(false);
                }
                break;
            case 3:
                if (Items.Photo03 == true)
                {
                    Destroy(PhotoCollider);
                    PhotoCollider.SetActive(false);
                }
                break;
            case 4:
                if (Items.Photo04 == true)
                {
                    Destroy(PhotoCollider);
                    PhotoCollider.SetActive(false);
                }
                break;
            case 5:
                if (Items.Photo05 == true)
                {
                    Destroy(PhotoCollider);
                    PhotoCollider.SetActive(false);
                }
                break;
            case 6:
                if (Items.Photo06 == true)
                {
                    Destroy(PhotoCollider);
                    PhotoCollider.SetActive(false);
                }
                break;
            case 7:
                if (Items.Photo07 == true)
                {
                    Destroy(PhotoCollider);
                    PhotoCollider.SetActive(false);
                }
                break;
        }
                
          
       
        
    }

}
