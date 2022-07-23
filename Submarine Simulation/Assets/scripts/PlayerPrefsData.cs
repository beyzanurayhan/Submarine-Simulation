using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsData : MonoBehaviour
{
    
    
    void Start()
    {
        PlayerPrefs.SetFloat("MotorGucu",100f);
        PlayerPrefs.SetInt("MotorSayisi", 1);
        PlayerPrefs.SetFloat("AracinAgirligi", 150);
        PlayerPrefs.SetString("AracinAdi","Submarine");
        PlayerPrefs.SetString("AracinTipi", "Denizalti");

        
    }


    void Update()
    {
        
    }
}
