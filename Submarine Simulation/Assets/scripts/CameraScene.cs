using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScene : MonoBehaviour
{
    public Camera SubmarineCamera;
    public Camera submarineFps;
    public bool isFps;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            isFps = !isFps;
            CheckCamera();
        }
    }
    void CheckCamera()
    {
        if (isFps)
        {
            submarineFps.enabled = true;
            SubmarineCamera.enabled = false;
        }
        else
        {
            submarineFps.enabled = false;
            SubmarineCamera.enabled = true;
        }
    }
}
