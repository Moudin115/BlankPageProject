using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private bool playerDetected;
    public Transform doorPos;
    public float width;
    public float height;
    public Animator Transition;

    public LayerMask whatIsPlayer;

    [SerializeField]
    private string sceneName;

    SceneSwitch sceneSwitch;

    private void Start()
    {
        sceneSwitch = FindObjectOfType<SceneSwitch>();
    }

    private void Update()
    {
        playerDetected = Physics2D.OverlapBox(doorPos.position, new Vector2(width, height), 0, whatIsPlayer);

        if (playerDetected == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/Interactables/door_inside");
                sceneSwitch.SwitchScene(sceneName);
                Transition.SetTrigger("Start");
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(doorPos.position, new Vector3(width, height, 1));
    }
}
