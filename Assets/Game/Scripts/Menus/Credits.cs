using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Interact")|| (Input.GetButtonDown("Back")) || (Input.GetButtonDown("Photo")) || (Input.GetButtonDown("Escape")))
        {
            Items.Camera = false;
            Items.Luggage = false;


            Items.Photo01 = false;
            Items.Photo02 = false;
            Items.Photo03 = false;
            Items.Photo04 = false;
            Items.Photo05 = false;
            Items.Photo06 = false;
            Items.Photo07 = false;

            PackTrig.hasPacked = false;
            MomTrig.MomDialogue = false;
            Jan.WalkCompleted = false;

            SceneManager.LoadScene("MainMenu");
        }
    }
}
