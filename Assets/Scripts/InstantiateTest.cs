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

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0)) //Left mouse button
        //{
        //    Instantiate(ball, transform.position, Quaternion.identity);
        //}
        if (Input.GetMouseButtonDown(0))
        {
            // K‰ytet‰‰n satunnaislukugeneraattoria, jonka laajuus on pallojen lukum‰‰r‰ 

            int randomNumber = Random.Range(0, ball.Length); // 0, 3
            
            Instantiate(ball[randomNumber], transform.position, Quaternion.identity);
        }




    }
}
