using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTest : MonoBehaviour
{
    GameObject searchObj;
    GameObject[] enemies;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Cube").SetActive(false);
        //enemies = GameObject.FindGameObjectsWithTag("Enemy");
        //searchObj = GameObject.FindWithTag("Enemy");
        //searchObj = GameObject.Find("Cube/Cube2/Enemy");
        //searchObj = GameObject.Find("Cube");

        //foreach (GameObject enemy in enemies)
        //{
        //    Destroy(enemy);
        //}


        //Destroy(searchObj);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
