using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolaroidRestrictionArea : MonoBehaviour
{
    private Vector2 minWalkPoint;
    private Vector2 maxWalkPoint;

    public Collider2D walkZone;

    public Transform Player;

    private int WalkDirection;

    public static bool isInCol;
    void Start()
    {
        minWalkPoint = walkZone.bounds.min;
        maxWalkPoint = walkZone.bounds.max;
    }

    // Update is called once per frame
    void Update()
    {
        switch (WalkDirection)
        {
            case 0:
                if (Player.position.x > maxWalkPoint.x)
                {
                    playerMovement.StopMovement = true;
                    return;
                }
                break;

            case 1:
                if (Player.position.x < minWalkPoint.x)
                {
                    playerMovement.StopMovement = true;
                    return;
                }
                break;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        isInCol = true;
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        isInCol = false;
    }
}
