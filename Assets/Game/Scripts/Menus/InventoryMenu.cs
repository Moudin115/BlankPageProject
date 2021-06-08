using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryMenu : MonoBehaviour
{
    public static bool InventoryVis = false;
    public static bool CameraVis = false;
    string ItemInHand = "Camera";
    public GameObject InventoryUI;
    public GameObject CameraMenuUI;

    //public PlayerMovement playerMovement;

    void Update()
    {
        if (ItemInHand == "Camera"){
            CamMenu();
        }
        
        if (Input.GetKeyDown(KeyCode.Q) && PauseMenu.GameIsPaused == false)
        {


            if (InventoryVis == true)
            {

                Resume();
            }
            else
            {
                    Inventory();
                    
            }
        }
    }
    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        InventoryUI.SetActive(false);
        InventoryVis = false;
    }
    void Inventory()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        InventoryUI.SetActive(true);
        InventoryVis = true;


    }
    void CamMenu()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (CameraVis == false)
            {
                CameraMenuUI.SetActive(true);
                CameraVis = true;
                CameraZoom.ZoomActive = true;
            }
            else
            {
                CameraMenuUI.SetActive(false);
                CameraVis = false;
                CameraZoom.ZoomActive = false;
            }

        }
    }
            
}
