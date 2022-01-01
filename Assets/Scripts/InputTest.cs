using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    public float speed;

    public GameObject ball;


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

        //float xInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        //float yInput = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        //print(xInput);

        //transform.Translate(xInput , yInput, 0);

        //Input.GetAxisRaw

        //if (Input.GetButtonDown("Fire1"))
        //{
        //    print(" Left Click");
        //}

        //if (Input.GetMouseButtonDown(0))
        //{

            //0 = left mouse button, 1 = right mouse button, 2 = mouse wheel
            //print (" Left Click ");

            //print(Input.mousePosition); // z on aina 0,0 koska screen
            //print(Input.mousePosition.x + " " + Input.mousePosition.y);

            //Talletetaan hiiren Paikka vektorimuuttujaan pos
            //Vector3 pos = Input.mousePosition;

            //Hiiren z on aina 0,0, siksi muutettava z, jotta saadaan spawnattua pallo pelimaailmaan
            //pos.z = 10f;

            //Screen koordinaatit ovat aina 2D screenin pinnassa, siksi nyt muutettava koordinaatit 
            //world -koordinaateiksi, jotta p‰‰st‰‰n 3D pelimaailman sis‰lle

            //pos = Camera.main.ScreenToWorldPoint(pos);

            //Instantiate(ball, pos, Quaternion.identity);
        //}
    }// update p‰‰ttyy t‰h‰n

    void OnMouseDown()
    {

        Destroy(gameObject);

    }



}
