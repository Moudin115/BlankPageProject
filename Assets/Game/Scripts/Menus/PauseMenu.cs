using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    //public GameObject GamePauseUI;
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;

    string Keycode;

    //public PlayerMovement playerMovement;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {


            if (GameIsPaused == true)
            {

                Resume();
            }
            else if (GameIsPaused == false)
            {

                Pause();
            }

            
        }
    }
    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        PauseMenuUI.SetActive(false);
        //GamePauseUI.SetActive(false);
        //Pointer.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        PauseMenuUI.SetActive(true);
        //Pointer.SetActive(false);
        Time.timeScale = 0; //Change for Slowmo effect
        //GamePauseUI.SetActive(true);
        GameIsPaused = true;


    }
    public void LoadMenu()
    {
        //playerMovement.stopMusic();
        GameIsPaused = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    /*public void ResetLevel()
    {
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        Debug.Log("Restarting ...");
        SceneManager.LoadScene("TestArea");
    }*/
}
