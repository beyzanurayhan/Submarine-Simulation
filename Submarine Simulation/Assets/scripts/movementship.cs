using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class movementship : MonoBehaviour
{
    private Rigidbody rb;
    float hiz1 = 3f;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }


    void Update()
    {

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(hiz1, 0, 0);
            //rb.AddForce(new Vector3(100f, 0, 0));
        }

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(-hiz1, 0, 0);
            //rb.AddForce(new Vector3(-100f, 0, 0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            //this.transform.Translate(1f, 0, 0);
            transform.Rotate(new Vector3(0, 1f, 0));
            //rb.AddForce(new Vector3(0, 0, 100f));
        }

        if (Input.GetKey(KeyCode.A))
        {
            //rb.AddForce(new Vector3(0, 0, -100f));
            transform.Rotate(new Vector3(0, -1f, 0));
            //this.transform.Translate(-1f, 0, 0);
        }

    }
}