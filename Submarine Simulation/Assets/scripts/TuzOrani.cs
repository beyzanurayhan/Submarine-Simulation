using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public class TuzOrani : MonoBehaviour
{
    public PostProcessVolume pv;
    private PostProcessProfile pp;
    private DepthOfField df;
    float value;

     void Start()
    {
        value = TuzOraniSlider.degeri;
    }
    private void Update()
    {
        pp = pv.profile;
        if (pp.TryGetSettings<DepthOfField>(out df))
        {
            df.focalLength.value = value;
        }
        Debug.Log("tuz " + value);
    }
}
