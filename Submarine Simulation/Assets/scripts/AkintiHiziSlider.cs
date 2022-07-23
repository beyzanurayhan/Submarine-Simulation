using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AkintiHiziSlider : MonoBehaviour
{
    public Slider sl;
    public Text svalue;
    public static float deger;

    void Update()
    {
        sl.maxValue = 100f;
        sl.minValue = -100f;
        svalue.text = sl.value.ToString("0.0") + "%";

    }
    public void Bitis()
    {
        deger = sl.value;
    }
}
