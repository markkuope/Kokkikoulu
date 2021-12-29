using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentTest : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        // Haetaan kuution Renderer -komponentti, haetaan sen materiaalikomponentti ja värikomponentti
        // ja muutetaan väriksi punainen
        GetComponent<Renderer>().material.color = Color.red;


        //rb = GetComponent<Rigidbody>();

        //rb.useGravity = false;
        //rb.mass = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
