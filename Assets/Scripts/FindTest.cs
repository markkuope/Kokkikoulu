using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTest : MonoBehaviour
{
    GameObject searchObj;

    // Start is called before the first frame update
    void Start()
    {

        searchObj = GameObject.Find("Cube/Cube2/Enemy");
        //searchObj = GameObject.Find("Cube");

        Destroy(searchObj);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
