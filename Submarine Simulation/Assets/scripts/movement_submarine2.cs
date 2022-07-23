using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_submarine2 : MonoBehaviour
{
    private Rigidbody rb;
    private float hiz1 = 0.5f;
    private float hizlanma = 2f;
    private MotorGucuSlider hizz;//diðer scriptten çaðýrabilmek için
    public GameObject hizz1;//diðer scriptten deðiþken alabilmek için

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //hizz = hizz.GetComponent<svalue>();//diðer scriptten component çaðrýmak için 

    }

    // Update is called once per frame
    void Update()
    {
        float hiz2;

        hiz2 = MotorGucuSlider.deger;
        //hizz.deger = hiz2; 
        //hiz2=hizz.deger;//deðerimizi eþitlemek için
        Debug.Log("hiz2 = gemi Hýzý " + hiz2);
        if (Input.GetKey(KeyCode.W))
        {
            this.rb.AddForce(transform.forward.normalized * hiz2 * PlayerPrefs.GetInt("MotorSayisi"));
            //this.transform.Translate(hiz2,0,0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.rb.AddForce(transform.forward.normalized * -hiz2 * PlayerPrefs.GetInt("MotorSayisi"));
        }
        if (Input.GetKey(KeyCode.D))
        {
            //this.transform.Translate(1f, 0, 0);
            transform.Rotate(new Vector3(0, 1f, 0));
            //rb.AddForce(new Vector3(0, 0, 100f));
        }

        if (Input.GetKey(KeyCode.A))
        {
            //rb.AddForce(new Vector3(0, 0, -100f));
            transform.Rotate(new Vector3(0, -1f, 0));
            //this.transform.Translate(-1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Rotate(new Vector3(0.5f, 0, 0));
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(new Vector3(-0.5f, 0, 0));
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, 0, 1f));
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 0, -1f));
        }
        if (Input.GetKey(KeyCode.Tab))
        {
            rb.AddForce(transform.forward.normalized * -150f);

        }

    }
}