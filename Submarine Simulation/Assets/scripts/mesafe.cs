using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mesafe : MonoBehaviour
{
    public Terrain tt;
    public Rigidbody rb;
    public TextMesh tm;
    public Transform sabit_nokta;
    public Transform degisken_nokta;
    float mesafe1;


    void Update()
    {
        float mesafe1 = sabit_nokta.position.y-tt.SampleHeight(transform.position);
        tm.text =mesafe1.ToString();
        


    }
}
