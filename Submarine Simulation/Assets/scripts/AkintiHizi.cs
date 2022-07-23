using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AkintiHizi : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {


    }
    void Update()
    {
        rb = GetComponent<Rigidbody>();
        float akintihizi = AkintiHiziSlider.deger;
        rb.AddForce(new Vector3(0, 0, akintihizi));
    }
}

