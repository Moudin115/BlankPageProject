using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{

    public float moveSpeed;
    private Vector2 minWalkPoint;
    private Vector2 maxWalkPoint;


    private Rigidbody2D rb;

    public bool isWalking;

    public float walkTime;
    private float walkCounter;
    public float waitTime;
    private float waitCounter;

    private int WalkDirection;

    public Collider2D walkZone;
    private bool hasWalkZone;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        waitCounter = waitTime;
        walkCounter = walkTime;

        ChooseDirection();


        if (walkZone != null)
        {
            minWalkPoint = walkZone.bounds.min;
            maxWalkPoint = walkZone.bounds.max;
            hasWalkZone = true;
        }
    }

    private void Update()
    {
        
        if (isWalking)
        {
            
            walkCounter -= Time.deltaTime;
            
            switch (WalkDirection)
            {
                case 0:
                    rb.velocity = new Vector2(moveSpeed, 0);
                    if (hasWalkZone && transform.position.x > maxWalkPoint.x)
                    {
                        
                        
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    break;

                case 1:
                    rb.velocity = new Vector2(-moveSpeed, 0);
                    if (hasWalkZone && transform.position.x < minWalkPoint.x)
                    {
                        
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    break;

                    //if y is given make more cases with y transformation
            }

            if (walkCounter < 0)
            {
                isWalking = false;
                waitCounter = waitTime;
            }

        }
        else
        {
            waitCounter -= Time.deltaTime;

            rb.velocity = Vector2.zero;

            if(waitCounter < 0)
            {
                ChooseDirection();
            }
        }
    }

    public void ChooseDirection()
    {
        WalkDirection = Random.Range(0, 2);
        isWalking = true;
        walkCounter = walkTime;
    }
}
