using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Packing : MonoBehaviour
{
    public GameObject PackageTrigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Jan.WalkCompleted == true)
        {
            PackageTrigger.SetActive(true);
        }
    }
}
