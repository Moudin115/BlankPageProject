using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryMenu : MonoBehaviour
{
    public static bool InventoryVis = false;
    public GameObject InventoryUI;

    string Keycode;

    //public PlayerMovement playerMovement;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && PauseMenu.GameIsPaused == false)
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
}
