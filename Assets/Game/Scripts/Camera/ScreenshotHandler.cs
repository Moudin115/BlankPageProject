using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenshotHandler : MonoBehaviour
{
    private static ScreenshotHandler instance;
    private Camera Cam;
    private bool takeScreenshotOnNextFrame;
    private int ScreenshotCounter = 1;

    public static string currentScene;

    private void Awake()
    {
        instance = this;
        Cam = gameObject.GetComponent<Camera>();
    }

    private void LateUpdate()
    {
        if (takeScreenshotOnNextFrame)
        {
            takeScreenshotOnNextFrame = false;
            RenderTexture renderTexture = Cam.targetTexture;

            
            Rect rect = new Rect(Screen.width/2-300, Screen.height/2-300, renderTexture.width, renderTexture.height);
            Texture2D renderResult = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.RGB24, false);

            renderResult.ReadPixels(rect,0,0);
            renderResult.Apply();

            //encoding to Screenshot
            byte[] byteArray = renderResult.EncodeToPNG();
            currentScene = SceneManager.GetActiveScene().name;

            switch (currentScene)
            {
                case "Photo_01":
                    ScreenshotCounter = 1;
                    break;
                case "Photo_02":
                    ScreenshotCounter = 2;
                    break;
                case "Photo_03":
                    ScreenshotCounter = 3;
                    break;
                case "Photo_04":
                    ScreenshotCounter = 4;
                    break;
                case "Photo_05":
                    ScreenshotCounter = 5;
                    break;
                case "Photo_06":
                    ScreenshotCounter = 6;
                    break;
                case "Photo_07":
                    ScreenshotCounter = 7;
                    break;
            }
            System.IO.File.WriteAllBytes(Application.dataPath + "/PhotoAlbum/PolaroidShot" + ScreenshotCounter.ToString() + ".png", byteArray);

            Debug.Log("saved Picture");
            AssetDatabase.Refresh();
            RenderTexture.ReleaseTemporary(renderTexture);
            //Cam.targetTexture = null;
        }
    }
    private void TakeScreenshot(int width, int height)
    {
        Cam.targetTexture = RenderTexture.GetTemporary(width, height);
        takeScreenshotOnNextFrame = true;
    }

    public static void TakeScreenshot_Static(int width, int height)
    {
        instance.TakeScreenshot(width, height);
    }
}
