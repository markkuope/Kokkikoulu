using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public int jumpForce;

    bool jump = false;

    float inputX, inputY;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Start is called before the first frame update
    void Start()
    {
        //rb.velocity = new Vector3(0, 0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }



    }

    void FixedUpdate()
    {

        rb.velocity = new Vector3(inputX * speed, rb.velocity.y, inputY * speed);

        if (jump)
        {
            Jump();

            jump = false;
        }



    }

    void Jump()
    {
        rb.AddForce(0, jumpForce, 0);
    }




}
