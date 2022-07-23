using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MotorSayisi : MonoBehaviour
{

    public TMPro.TMP_InputField myField;

    void Start()
    {
        
        myField.text = PlayerPrefs.GetInt("MotorSayisi").ToString();
        Debug.Log("Değeri " + PlayerPrefs.GetInt("MotorSayisi").ToString());
    }

    public void OnChanged()
    {
        
        int sayi = 0;
        if (int.TryParse(myField.text, out sayi) == true)
        {
            PlayerPrefs.SetInt("MotorSayisi", sayi);
            Debug.Log("Değer değişti " + myField.text);
        }
        else
        {
            Debug.Log("Hatalı değer girildi.");
        }
    }
    public void OnEnd()
    {
        int sayi = 0;
        if (int.TryParse(myField.text, out sayi) == true)
        {
            PlayerPrefs.SetInt("MotorSayisi", sayi);
            Debug.Log("Son Değeri " + myField.text);
        }
        else
        {
            Debug.Log("Hatalı değer girildi.");
        }
       
    }
    public void OnSelected()
    {
        Debug.Log("Selected");
    }
    public void OnDeselected()
    {
        Debug.Log("Deselected");
    }

}
