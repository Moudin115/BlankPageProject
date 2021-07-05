using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraZoom : MonoBehaviour
{
    public CinemachineVirtualCamera vcam;
    public float speed = 1;


    private void Start()
    {
    }

    public void Update()
    {
        float mouseWheel = Input.GetAxis("Mouse ScrollWheel");
        if(mouseWheel != 0)
        {
            vcam.m_Lens.OrthographicSize -= mouseWheel;
            if (vcam.m_Lens.OrthographicSize >= 3f)
            {
                vcam.m_Lens.OrthographicSize = 3f;
            }
            if (vcam.m_Lens.OrthographicSize <= 2f)
            {
                vcam.m_Lens.OrthographicSize = 2f;
            }
        }
    }
}
