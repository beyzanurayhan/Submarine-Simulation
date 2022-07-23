using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floater : MonoBehaviour
{
    public Rigidbody rb;
    public TextMesh tm;
    public float depthBeforeSubmerged = 25f;
    public float displacementAmount = 0.1f;

    private void FixedUpdate()
    {
       if(transform.position.y>= 57f)
        {
            rb.AddForce(new Vector3(0f, Mathf.Abs(Physics.gravity.y)*-1 , 0f), ForceMode.Acceleration);
        }
        if (transform.position.y < 57f && transform.position.y > 52f) 
        {
            float displacementMultiplier = (57f-transform.position.y) * displacementAmount+1f;
            tm.text = displacementMultiplier.ToString();
            //rb.AddForce(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * -1.5f, 0f), ForceMode.Acceleration);
            rb.AddForce(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * displacementMultiplier, 0f), ForceMode.Acceleration);
        }
        if (transform.position.y <= 52f && transform.position.y > 47f) 
        {
            float displacementMultiplier = (transform.position.y-47f) * displacementAmount+1.1f;
            //rb.AddForce(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * 1.5f, 0f), ForceMode.Acceleration);
            rb.AddForce(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * displacementMultiplier, 0f), ForceMode.Acceleration);
        }
        if (transform.position.y <= 47)
        {
            rb.AddForce(new Vector3(0f, Mathf.Abs(Physics.gravity.y), 0f), ForceMode.Acceleration);
        }
    }
}