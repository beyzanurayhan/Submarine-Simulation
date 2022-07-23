using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class random_haraket_2 : MonoBehaviour
{
    int counter = 0;
    float yon1, yon2;
    float d1, d2;
    public bool hareketEt;
    public bool hareketEt2;
    int m;
    System.Random rnd = new System.Random();

    // Start is called before the first frame update

    [System.Obsolete]
    void Start()
    {

        counter = 0;
        hareketEt = true;

    }

    // Update is called once per frame
    void Update()
    {

        if (counter == 0)
        {

            do
            {
                m = Random.Range(0, 3) - 1;
            }
            while (m == 0);


            d1 = Random.Range(0.2f, 0.4f);
            d2 = Random.Range(0.2f, 0.4f);
            yon1 = Random.Range(0.4f, 1f);
            yon2 = Random.Range(0.4f, 1f);
        }

        if (hareketEt == true)
        {

            this.transform.Translate(0, 0, -yon1);
            transform.Rotate(new Vector3(0, d1 * m, 0));
            counter++;
            if (counter > 100)
            {
                hareketEt = false;
                hareketEt2 = true;
                counter = 0;
            }


        }


        else if (hareketEt2 == true && hareketEt == false)
        {
            this.transform.Translate(0, 0, -yon2);
            transform.Rotate(new Vector3(0, d2 * m * 2, 0));
            counter++;
            if (counter > 100)
            {
                hareketEt2 = false;
                hareketEt = true;
                counter = 0;
            }

        }

        //if (hareketEt2 == true)
        //{

        //}



    }
}
