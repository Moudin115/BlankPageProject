using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whiteBlendAnim : MonoBehaviour
{
    public GameObject Blend;
    public Animator BlendAnim;

    public GameObject Polaroid;
    public Animator PolaroidAnim;


    void Start()
    {
        Polaroid.SetActive(true);
        PolaroidAnim.SetTrigger("Start");
        Blend.SetActive(true);
        BlendAnim.SetTrigger("Start");
    }


}
