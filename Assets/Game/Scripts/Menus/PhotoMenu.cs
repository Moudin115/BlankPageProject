using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhotoMenu : MonoBehaviour
{
    string lastScene = "Village";
    public GameObject Menu;

    public Camera Polaroidcam;
    public float speed = 1;

    private bool EisPressed = false;

    public GameObject Blend;
    public Animator BlendAnim;

    

    // Start is called before the first frame update
    void Start()
    {
        SceneSwitch.prevScene = "Village";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(sceneName: lastScene);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Menu.SetActive(false);
            EisPressed = true;
        }
        if (EisPressed)
        {
            float horz = Input.GetAxis("Horizontal");
            float vert = Input.GetAxis("Vertical");
            Polaroidcam.transform.position += (Vector3.up * vert + Vector3.right * horz) * speed * Time.deltaTime;

            float mouseWheel = Input.GetAxis("Mouse ScrollWheel");
            if (mouseWheel != 0)
            {
                Polaroidcam.orthographicSize -= mouseWheel;
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ScreenshotHandler.TakeScreenshot_Static(500, 500);
                FMODUnity.RuntimeManager.PlayOneShot("event:/Interactables/camera_trigger");
                Blend.SetActive(true);
                BlendAnim.Play("BlendAnim_Menu");
                Items.Photo01 = true;
                SceneManager.LoadScene(sceneName: "PhotoWall");
            }
        }
    }
}
