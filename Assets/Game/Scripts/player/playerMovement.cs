using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class playerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 20f;
    private float runSpeedP;
    public float LayerMode = 1;

    float horizontalMove = 0f;
    bool jump = false;

    public static bool StopMovement = false;

    private DialogueRunner dialogueRunner = null;

    public Animator anim;
    private void Start()
    {
        runSpeedP = 20f;
        dialogueRunner = FindObjectOfType<DialogueRunner>();
    }

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

        if (dialogueRunner != null)
        {
            if (dialogueRunner.IsDialogueRunning == false)
            {
                StopMovement = false;
                runSpeed = runSpeedP;
            }
            else if (dialogueRunner.IsDialogueRunning == true)
            {
                StopMovement = true;
                runSpeed = 0f;
                return;

            }
        }
        

        if (horizontalMove == 0)
        {
            anim.SetBool("walkBool", false);

        }
        if (horizontalMove != 0)
        {
            anim.SetBool("walkBool", true);
        }


    }

    private void FixedUpdate()
    {
        //Move Character
        if (StopMovement == false)
        {
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
            jump = false;
            
        }
        if (StopMovement == true)
        {
            
            controller.Move(0f,false,jump);
            jump = false;

        }
    }
}
