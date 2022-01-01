using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    print(" Space n‰pp‰int‰ painettu ");
        //    GetComponent<Renderer>().material.color = Color.green;
        //}
        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    print(" Space n‰pp‰in vapautettu ");
        //    GetComponent<Renderer>().material.color = Color.yellow;
        //}
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    print(" Space n‰pp‰in alhaalla  ");
        //}


        //if (Input.GetButtonDown("Jump"))
        //{
        //    print(" Space n‰pp‰int‰ painettu ");

        //    GetComponent<Renderer>().material.color = Color.green;
        //}

         float xInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

         float yInput = Input.GetAxis("Vertical") * speed * Time.deltaTime;

         print(xInput);

         transform.Translate(xInput , yInput, 0);

        //Input.GetAxisRaw

    } // update p‰‰ttyy t‰h‰n
}
