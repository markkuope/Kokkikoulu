using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentTest : MonoBehaviour
{
    Rigidbody rb;

    //luodaan PlayerHealth -tyyppinen muuttuja ja annetaan sille nimeksi health
    PlayerHealth health;


    // Start is called before the first frame update
    void Start()
    {
        // Haetaan kuution Renderer -komponentti, haetaan sen materiaalikomponentti ja v�rikomponentti
        // ja muutetaan v�riksi punainen
        GetComponent<Renderer>().material.color = Color.red;

        //rb = GetComponent<Rigidbody>();
        //rb.useGravity = false;
        //rb.mass = 10;

        // Haetaan PlayerHealth -scripti ja tallennetaan se health -muuttujaan
        health = GetComponent<PlayerHealth>();

        // Muutetaan PlayerHealth -scriptin lives arvoa
        health.lives = 9;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
