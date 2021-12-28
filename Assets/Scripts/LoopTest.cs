using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(" Ennen for -silmukkaa ");
        for (int i = 1; i < 6; i++)
        {
            print(" Markku ");
        }
        print(" Silmukan jälkeen ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
