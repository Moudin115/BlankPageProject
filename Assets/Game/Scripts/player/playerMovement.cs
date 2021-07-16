using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class playerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 18f;
    private float runSpeedP;
    public float LayerMode = 1;

    float horizontalMove = 0f;
    bool jump = false;

    public static bool StopMovement = false;
    
    private DialogueRunner dialogueRunner = null;

    public Animator anim;

    private bool Colliding = false;
    private void Start()
    {
        runSpeedP = 18f;
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
                anim.SetBool("walkBool", true);
            }
            else if (dialogueRunner.IsDialogueRunning == true)
            {
                StopMovement = true;
                anim.SetBool("walkBool", false);
                runSpeed = 0f;
                return;

            }
        }
        

        if (horizontalMove == 0)
        {
            anim.SetBool("walkBool", false);

        }
        if (horizontalMove != 0 && Colliding == false)
        {
            anim.SetBool("walkBool", true);
        }
        else anim.SetBool("walkBool", false);


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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Colliding = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Colliding = false;
    }
}
