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

    private static FMOD.Studio.EventInstance EndS;

    private void Start()
    {
        EndS = FMODUnity.RuntimeManager.CreateInstance("event:/BackgroundMusic/EndingTheme");
        EndS.start();
        EndS.release();
    }
    // Update is called once per frame
    void Update()
    {
        EndS.setParameterByName("EndingThemeLoop", 0f);
        EndS.setParameterByName("EndingThemeGuests", 0f);
        if (jan == true) _jan.SetActive(true);
        if (joe == true) _joe.SetActive(true);
        if (mom == true) _mom.SetActive(true);

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Credits");
        }
    }
}
