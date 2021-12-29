using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTest : MonoBehaviour
{
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position + new Vector3(0, 1f, 0);
        //transform.position += new Vector3 (0, 0.1f, 0);
        //transform.position += transform.forward * speed; // (0 , 0 , 1)
        //transform.Translate(speed, 0, 0);
        //transform.Rotate(speed, 0, 0);
        //transform.localScale += new Vector3(0, speed, 0);
        //transform.localScale += transform.up * speed;
    }
}
