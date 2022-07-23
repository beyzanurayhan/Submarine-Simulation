using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareketsubmarine : MonoBehaviour
{
    private Rigidbody rb;
    private float hiz1 = 10f;
    private float hizlanma = 2f;
    System.DateTime dt0;
    System.DateTime dt1;
    System.TimeSpan fark;
    bool click = false;

    // Start is called before the first frame update
    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0, 0, -hiz1);
            //rb.AddForce(new Vector3(100f, 0, 0));
        }

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0, 0, hiz1);
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
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Rotate(new Vector3(0.1f, 0, 0));
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(new Vector3(-0.1f, 0, 0));
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, 0, 1f));
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 0, -1f));
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.Z))
        {
            float saniye = 1;
            if (click == false)
            {
                click = true;
                dt0 = System.DateTime.Now;
            }
            else
            {
                dt1 = System.DateTime.Now;
                fark = (dt1 - dt0);
                saniye = (float)fark.TotalSeconds;
            }


            transform.Translate(0, 0, saniye * hiz1);
        }
        else
        {
            click = false;
        }
    }
}
