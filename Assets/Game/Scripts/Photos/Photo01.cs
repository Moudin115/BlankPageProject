using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Photo01 : MonoBehaviour
{

    public GameObject PhotoCollider;

    public static bool Trigger = false;

    // Start is called before the first frame update
    void Start()
    {
        SceneSwitch.prevScene = "Village";
        if (Items.Photo01 == true)
        {
            Destroy(PhotoCollider);
        }
    }

    // Update is called once per frame
    void Update()
    {
            if (PolaroidRestrictionArea.walkStop == true)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                Items.Photo01 = true;
                Destroy(PhotoCollider);
                }
            }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Trigger = true;
            Debug.Log("Trigg");
        }
    }
}
