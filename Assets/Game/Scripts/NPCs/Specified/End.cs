using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{


    public static bool jan;
    public static bool mom;
    public static bool joe;

    public GameObject _jan;
    public GameObject _joe;
    public GameObject _mom;


    // Update is called once per frame
    void Update()
    {
        if (jan == true) _jan.SetActive(true);
        if (joe == true) _joe.SetActive(true);
        if (mom == true) _mom.SetActive(true);

        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Credits");
        }
    }
}
