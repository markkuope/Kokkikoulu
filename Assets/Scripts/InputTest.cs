using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    print(" Space näppäintä painettu ");
        //    GetComponent<Renderer>().material.color = Color.green;
        //}
        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    print(" Space näppäin vapautettu ");
        //    GetComponent<Renderer>().material.color = Color.yellow;
        //}
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    print(" Space näppäin alhaalla  ");
        //}


        if (Input.GetButtonDown("Jump"))
        {
            print(" Space näppäintä painettu ");

            GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
