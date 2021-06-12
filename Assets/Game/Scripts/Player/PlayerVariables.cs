using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerVariables : MonoBehaviour
{
    public int maxHealth = 20;
    public int currentHealth;

    public CamBar camBar;

    private void Start()
    {

        currentHealth = maxHealth;
        camBar.SetMaxHealth(maxHealth);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            TakePicture(1);
        }
    }

    void TakePicture(int picture)
    {
        currentHealth -= picture;

        camBar.SetHealth(currentHealth);
    }
}
    
