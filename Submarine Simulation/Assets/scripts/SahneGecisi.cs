using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SahneGecisi : MonoBehaviour
{
    public void OrtamSahnesi()
    {
        SceneManager.LoadScene("giris2");
        
    }
    public void TeknikSahne()
    {
        SceneManager.LoadScene("seubmarine");
    }
    public void DenizSahne()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
