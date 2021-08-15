using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static FMOD.Studio.EventInstance EndS;
    public static FMOD.Studio.EventInstance EndS2;
    public static FMOD.Studio.EventInstance BGM;

    public int MenuState = 0;

    
    bool axisInUse = false;

    public Animator anim_btnStart;
    public Animator anim_btnAbout;
    public Animator anim_btnExit;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        EndS = FMODUnity.RuntimeManager.CreateInstance("event:/BackgroundMusic/MenuTheme");
        EndS.start();
        EndS.release();

        EndS2 = endMusicTrig.EndS;
        EndS2.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        BGM = ParametersSetByName.BGM;
    }
    private void Update()
    {
        //EndS.setParameterByName("EndingThemeLoop", 1f);
        BGM.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);

        ChangeOption();
    }
    public void ChangeOption()
    {
        float verticalInput = Input.GetAxis("Vertical");
        if (verticalInput < 0)
        {
            if (!axisInUse)
            {
                MenuState += 1;
                axisInUse = true;
            }
        }
        if (verticalInput > 0)
        {
            if (!axisInUse)
            {
                MenuState -= 1;
                axisInUse = true;
            }
        }
        if (verticalInput == 0) axisInUse = false;

        if (MenuState == 3) MenuState = 0;
        if (MenuState == -1) MenuState = 2;

        switch (MenuState)
        {
            case 0:
                Debug.Log("MenuState 0");
                anim_btnStart.SetBool("Highlighted", true);
                anim_btnAbout.SetBool("Highlighted", false);
                anim_btnExit.SetBool("Highlighted", false);
                if (Input.GetButtonDown("Interact"))
                {
                    PlayGame();
                }
                break;
            case 1:
                Debug.Log("MenuState 1");
                anim_btnStart.SetBool("Highlighted", false);
                anim_btnAbout.SetBool("Highlighted", true);
                anim_btnExit.SetBool("Highlighted", false);
                if (Input.GetButtonDown("Interact"))
                {
                    About();
                }
                break;
            case 2:
                Debug.Log("MenuState 2");
                anim_btnStart.SetBool("Highlighted", false);
                anim_btnAbout.SetBool("Highlighted", false);
                anim_btnExit.SetBool("Highlighted", true);
                if (Input.GetButtonDown("Interact"))
                {
                    QuitGame();
                }
                break;
        }
    }
    public void PlayGame()
    {
        BGM.start();
        BGM.release();
        EndS.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void About()
    {
        EndS.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        SceneManager.LoadScene("Credits");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
