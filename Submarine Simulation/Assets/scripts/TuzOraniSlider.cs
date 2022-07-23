using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TuzOraniSlider : MonoBehaviour
{
    public Slider sll;
    public Text slidervalue;
    public static float degeri;

    
    void Update()
    {
        sll.maxValue = 100f;
        sll.minValue = 0;
        slidervalue.text = sll.value.ToString("0.0")+"%";
    }
    public void Degeri() 
    {
        degeri = sll.value;
    }
}
