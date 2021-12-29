using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachTest : MonoBehaviour
{
    public GameObject[] objects;


    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject o in objects)
        {
            //Tuhotaan kaikki taulukon peliobjektit
            //Destroy(o);

            o.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
