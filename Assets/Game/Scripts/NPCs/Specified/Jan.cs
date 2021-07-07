using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jan : MonoBehaviour
{

    public static Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public static void Janwalk()
    {
        anim.SetBool("isWalking", true);
    }
}
