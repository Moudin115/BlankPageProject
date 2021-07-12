using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class TurnTo : MonoBehaviour
{
    private DialogueRunner dialogueRunner;

    private Transform target;
    public GameObject tar;

    public GameObject sprite;
    private bool spoken = false;
    void Start()
    {
        Vector2 Spriter = this.transform.localScale;
        dialogueRunner = FindObjectOfType<DialogueRunner>();
        target = tar.GetComponent<Transform>();
    }

    
    void Update()
    {
        if (dialogueRunner.IsDialogueRunning == true)
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
    }
}
