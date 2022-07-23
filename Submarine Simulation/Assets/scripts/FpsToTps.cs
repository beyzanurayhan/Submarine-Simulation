using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsToTps : MonoBehaviour
{
    public Camera BotFps;
    public Camera BotTps;
    public bool isFPS;
    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            isFPS = !isFPS;
            CheckCamera();
        }
    }

    void CheckCamera()
    {
        if (isFPS)
        {
            BotFps.enabled = true;
            BotTps.enabled = false;
        }
        else
        {
            BotFps.enabled = false;
            BotTps.enabled = true;
        }
    }

}
