using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlbumMenu : MonoBehaviour
{
    public static bool Photo01;
    public static bool Photo02;
    public static bool Photo03;
    public static bool Photo04;
    public static bool Photo05;
    public static bool Photo06;
    public static bool Photo07;
    public static bool Photo08;
    public static bool Photo09;
    public static bool Photo10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Photo01")
        {
            AlbumMenu.Photo01 = true;
            Debug.Log("Photo01");
        }
        if (collision.tag == "Photo02")
        {
            AlbumMenu.Photo02 = true;
        }
        if (collision.tag == "Photo03")
        {
            AlbumMenu.Photo03 = true;
        }
        if (collision.tag == "Photo04")
        {
            AlbumMenu.Photo04 = true;
        }
        if (collision.tag == "Photo05")
        {
            AlbumMenu.Photo05 = true;
        }
        if (collision.tag == "Photo06")
        {
            AlbumMenu.Photo06 = true;
        }
        if (collision.tag == "Photo07")
        {
            AlbumMenu.Photo07 = true;
        }
        if (collision.tag == "Photo08")
        {
            AlbumMenu.Photo08 = true;
        }
        if (collision.tag == "Photo09")
        {
            AlbumMenu.Photo09 = true;
        }
        if (collision.tag == "Photo10")
        {
            AlbumMenu.Photo10 = true;
        }
    }
}
