using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Photo01 : MonoBehaviour
{

    public GameObject PhotoCollider;

    // Start is called before the first frame update
    void Start()
    {
        
                if (Items.Photo01 == true)
                {
                    Destroy(PhotoCollider);
            PhotoCollider.SetActive(false);
        }
          
       
        
    }

}
