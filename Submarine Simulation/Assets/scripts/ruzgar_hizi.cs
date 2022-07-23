using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruzgar_hizi : MonoBehaviour
{
    public float ruzgarhizi;
    void Update()
    {
        ruzgarhizi = AkintiHiziSlider.deger;
        this.transform.Translate(ruzgarhizi, 0, 0);
        
    }
}
