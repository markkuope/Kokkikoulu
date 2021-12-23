using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicVariables : MonoBehaviour
{
    //kokonaisluku int
    public int score = 10;

    // teksti string
    public string nimi = " Markku ";
   
    void Start()
    {
        print(" My name is " + nimi);
        print(" My score is " + score);
    }
}


