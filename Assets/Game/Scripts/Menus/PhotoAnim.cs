using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoAnim : MonoBehaviour
{

    public GameObject PicMenu;

    public GameObject Pic01;
    public Animator Pic01Anim;

    /*public GameObject Pic02;
    public Animator Pic02Anim;

    public GameObject Pic03;
    public Animator Pic03Anim;

    public GameObject Pic04;
    public Animator Pic04Anim;

    public GameObject Pic05;
    public Animator Pic05Anim;

    public GameObject Pic06;
    public Animator Pic06Anim;

    public GameObject Pic07;
    public Animator Pic07Anim;*/

    void Start()
    {

        if (Items.Photo01 == true || Items.Photo02 == true || Items.Photo03 == true || Items.Photo04 == true || Items.Photo05 == true || Items.Photo06 == true || Items.Photo07 == true)
        {
            if (Items.Photo01 == true)
            {
                Pic01.SetActive(true);
                Pic01Anim.SetTrigger("Start");
            }
           /* if (Items.Photo02 == true)
            {
                Pic02.SetActive(true);
                Pic02Anim.SetTrigger("Start");
            }
            if (Items.Photo03 == true)
            {
                Pic03.SetActive(true);
                Pic03Anim.SetTrigger("Start");
            }
            if (Items.Photo04 == true)
            {
                Pic04.SetActive(true);
                Pic04Anim.SetTrigger("Start");
            }
            if (Items.Photo05 == true)
            {
                Pic05.SetActive(true);
                Pic05Anim.SetTrigger("Start");
            }
            if (Items.Photo06 == true)
            {
                Pic06.SetActive(true);
                Pic06Anim.SetTrigger("Start");
            }
            if (Items.Photo07 == true)
            {
                Pic07.SetActive(true);
                Pic07Anim.SetTrigger("Start");
            }*/
        }
    }
    public void GoBack()
    {
        Pic01.SetActive(false);
        /*Pic02.SetActive(false);
        Pic03.SetActive(false);
        Pic04.SetActive(false);
        Pic05.SetActive(false);
        Pic06.SetActive(false);
        Pic07.SetActive(false);*/
        PicMenu.SetActive(false);
    }
}
