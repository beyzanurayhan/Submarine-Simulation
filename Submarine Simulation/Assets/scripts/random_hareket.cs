using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_hareket : MonoBehaviour
{
    
    public Transform[] yon, yon2;
    public Transform secilenYon;
    public Transform secilenYon2;
    public bool hareketEt;
    public float hareketHizi;
    public float durmaMesafesi;
    // Start is called before the first frame update
    void Start()
    {
        yon = new Transform[2];
        for (int i = 0; i < yon.Length; i++)
        {
            yon[i] = GameObject.Find(i + 1 + ".Nokta").transform;
        }
        if (hareketEt == false)
        {
            secilenYon = yon[Random.Range(0, yon.Length)];
            hareketEt = true;

        }

    }


    void Update()
    {
        float hiz1;
        if (hareketEt == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, secilenYon.position, hareketHizi * Time.deltaTime);
        }
    }
    //void Start2()
    //{
    //    yon2 = new Transform[3];

    //    for (int i = 0; i < yon2.Length; i++)
    //    {
    //        yon2[i] = GameObject.Find(i + 1 + ".Nokta").transform;
    //    }
    //    if (hareketEt == false)
    //    {
    //        secilenYon2 = yon2[Random.Range(0, yon2.Length)];
    //        hareketEt = true;

    //    }
    //}
    //void Update2()
    //{
    //    if (hareketEt == true)
    //    {
    //        transform.position = Vector3.MoveTowards(transform.position, secilenYon2.position, hareketHizi * Time.deltaTime);
    //    }
    //}
}
