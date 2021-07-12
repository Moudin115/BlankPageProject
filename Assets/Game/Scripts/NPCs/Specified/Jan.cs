using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Jan : MonoBehaviour
{

    public float speed = 2f;

    public Animator anim;

    private Transform target;
    public GameObject tar;

    public GameObject sprite;

    private int WalkDirection;

    public static bool JanIsFollowing;
    public static bool WalkCompleted;

    private DialogueRunner dialogueRunner;

    public bool startTalk;
    // Start is called before the first frame update
    void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
        target = tar.GetComponent<Transform>();
        if (JanIsFollowing && DialogueTriggerJan.aboutTrig)
        {
            Debug.Log("Photo_03");
            transform.position = new Vector2(tar.transform.position.x - 3, tar.transform.position.y);
            dialogueRunner.StartDialogue("aboutPhotos");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (dialogueRunner.IsDialogueRunning)
        {
            if (tar.transform.position.x > this.transform.position.x)
            {
                sprite.transform.localScale = new Vector2(-1f, 1f);
            }
            if (tar.transform.position.x < this.transform.position.x)
            {
                sprite.transform.localScale = new Vector2(1f, 1f);
            }
        }
            if (JanIsFollowing)
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
        if (WalkCompleted == true)
        {
            anim.SetBool("idleBool", true);
        }

    }

    public static void Janwalk()
    {
        JanIsFollowing = true;
    }
    public static void endJanwalk()
    {
        JanIsFollowing = false;
        WalkCompleted = true;
    }
}