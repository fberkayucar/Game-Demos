using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    void Start()
    {
        cam2.SetActive(false);
        cam1.SetActive(true);
    }

    void Update()
    {
        switchCamera();
    }
    void switchCamera()
    {
        if (Input.GetKey(KeyCode.C))
        {
            cam2.SetActive(true);
            cam1.SetActive(false);
        }
        else
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
    }
}
