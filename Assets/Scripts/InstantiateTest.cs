using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTest : MonoBehaviour
{

    //public GameObject ball;
    public GameObject[] ball;


    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(ball, transform.position, Quaternion.identity);
        //Quaternion.identity means no rotation
        //Invoke("RandomBall", 5f);
        // Funktiota kutsutaan 2 sekunnin p‰‰st‰, sen j‰lkeen 1 sekunnin v‰lein
        InvokeRepeating("RandomBall", 2f, 1f);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //Left mouse button
        {
            //    Instantiate(ball, transform.position, Quaternion.identity);
            CancelInvoke("RandomBall");
        }
        //if (Input.GetMouseButtonDown(0))
        //{
        //    // K‰ytet‰‰n satunnaislukugeneraattoria, jonka laajuus on pallojen lukum‰‰r‰ 

        //    int randomNumber = Random.Range(0, ball.Length); // 0, 3
            
        //    Instantiate(ball[randomNumber], transform.position, Quaternion.identity);
        //}
    } //update p‰‰ttyy t‰h‰n

    void RandomBall()
    {

        int randomNumber = Random.Range(0, ball.Length); // 0, 3

        Instantiate(ball[randomNumber], transform.position, Quaternion.identity);

    }



}
