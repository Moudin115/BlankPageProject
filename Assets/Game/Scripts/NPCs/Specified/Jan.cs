using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jan : MonoBehaviour
{

    public float speed = 2f;

    public Animator anim;

    private Transform target;
    public GameObject tar;

    public GameObject sprite;

    private int WalkDirection;

    // Start is called before the first frame update
    void Start()
    {
        target = tar.GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (tar.transform.position.x > this.transform.position.x)
        {
            sprite.transform.localScale = new Vector2(-1f, 1f);
        }
        if (tar.transform.position.x < this.transform.position.x)
        {
            sprite.transform.localScale = new Vector2(1f, 1f);
        }

        anim.SetBool("isWalking", false);
        if (Vector2.Distance(transform.position, target.position) > 1)
        {
            anim.SetBool("isWalking", true);
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        
    }

    public static void Janwalk()
    {
        
    }
}
