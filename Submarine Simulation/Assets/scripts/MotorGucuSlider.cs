using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MotorGucuSlider : MonoBehaviour
{
    public  Slider sl;//de�i�kenler
    public Text slvalue;
    public static float deger;  
    
    void Update()
    {
        
        slvalue.text = sl.value.ToString("0.0");//slider �n yan�ndaki de�erleri g�rebilmek i�in

    }
    public void Deneme()
    {

        deger = sl.value;//De�er adl� de�i�kenimizin o anki de�erini belirlemek i�in 
        
    }
}
