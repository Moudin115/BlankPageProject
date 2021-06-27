using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallWhiteBlend : MonoBehaviour
{
    public Animator BlendAnim01;
    public Animator BlendAnim02;
    public Animator BlendAnim03;
    public Animator BlendAnim04;
    public Animator BlendAnim05;
    public Animator BlendAnim06;
    public Animator BlendAnim07;

    private bool Photo01OnWall;
    private bool Photo02OnWall;
    private bool Photo03OnWall;
    private bool Photo04OnWall;
    private bool Photo05OnWall;
    private bool Photo06OnWall;
    private bool Photo07OnWall;

    void Start()
    {
        if (Photo01OnWall)
        {
            Destroy(BlendAnim01.gameObject);
        }
        if (Photo02OnWall)
        {
            Destroy(BlendAnim02.gameObject);
        }
        if (Photo03OnWall)
        {
            Destroy(BlendAnim03.gameObject);
        }
        if (Photo04OnWall)
        {
            Destroy(BlendAnim04.gameObject);
        }
        if (Photo05OnWall)
        {
            Destroy(BlendAnim05.gameObject);
        }
        if (Photo06OnWall)
        {
            Destroy(BlendAnim06.gameObject);
        }
        if (Photo07OnWall)
        {
            Destroy(BlendAnim07.gameObject);
        }


        if (Items.Photo01 == true)
        {
            BlendAnim01.SetTrigger("Start");
            Photo01OnWall = true;
        }
        if (Items.Photo02 == true)
        {
            BlendAnim02.SetTrigger("Start");
            Photo02OnWall = true;
        }
        if (Items.Photo03 == true)
        {
            BlendAnim03.SetTrigger("Start");
            Photo03OnWall = true;
        }
        if (Items.Photo04 == true)
        {
            BlendAnim04.SetTrigger("Start");
            Photo04OnWall = true;
        }
        if (Items.Photo05 == true)
        {
            BlendAnim05.SetTrigger("Start");
            Photo05OnWall = true;
        }
        if (Items.Photo06 == true)
        {
            BlendAnim06.SetTrigger("Start");
            Photo06OnWall = true;
        }
        if (Items.Photo07 == true)
        {
            BlendAnim07.SetTrigger("Start");
            Photo07OnWall = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
