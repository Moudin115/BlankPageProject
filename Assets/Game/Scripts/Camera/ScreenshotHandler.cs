using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class ScreenshotHandler : MonoBehaviour
{
    private static ScreenshotHandler instance;
    private Camera Cam;
    private bool takeScreenshotOnNextFrame;
    private int ScreenshotCounter = 1;


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

            Texture2D renderResult = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.ARGB32, false);
            Rect rect = new Rect(0, 0, renderTexture.width, renderTexture.height);
            renderResult.ReadPixels(rect, 0,0, false);
            renderResult.Apply();

            //encoding to Screenshot
            byte[] byteArray = renderResult.EncodeToPNG();
            System.IO.File.WriteAllBytes(Application.dataPath + "/PhotoAlbum/PolaroidShot" + ScreenshotCounter.ToString() + ".png", byteArray);

            ScreenshotCounter += 1;
            Debug.Log("saved Picture");
            AssetDatabase.Refresh();
            RenderTexture.ReleaseTemporary(renderTexture);
            Cam.targetTexture = null;
        }
    }
    private void TakeScreenshot(int width, int height)
    {
        Cam.targetTexture = RenderTexture.GetTemporary(width, height, 16);
        takeScreenshotOnNextFrame = true;
    }

    public static void TakeScreenshot_Static(int width, int height)
    {
        instance.TakeScreenshot(width, height);
    }
}
