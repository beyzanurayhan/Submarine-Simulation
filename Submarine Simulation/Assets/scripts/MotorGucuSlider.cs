using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MotorGucuSlider : MonoBehaviour
{
    public  Slider sl;//deðiþkenler
    public Text slvalue;
    public static float deger;  
    
    void Update()
    {
        
        slvalue.text = sl.value.ToString("0.0");//slider ýn yanýndaki deðerleri görebilmek için

    }
    public void Deneme()
    {

        deger = sl.value;//Deðer adlý deðiþkenimizin o anki deðerini belirlemek için 
        
    }
}
