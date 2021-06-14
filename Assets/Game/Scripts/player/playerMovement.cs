using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 40f;

    public float LayerMode = 1;

    float horizontalMove = 0f;
    bool jump = false;

    private void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        /*if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }*/


        /*if (Input.GetKeyDown(KeyCode.W))
        {
            if (LayerMode == 1)
            {
                LayerMode += 1;
                transform.position = new Vector3(transform.position.x, transform.position.y, (transform.position.z + 3));
            }
            
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (LayerMode == 2)
            {
                LayerMode -= 1;
                transform.position = new Vector3(transform.position.x, transform.position.y, (transform.position.z - 3));
                
            }

            }*/
    }

    private void FixedUpdate()
    {
        //Move Character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
