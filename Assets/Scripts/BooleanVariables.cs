using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanVariables : MonoBehaviour
{
    public bool gameover = true;
    public bool killPlayer;

    // Start is called before the first frame update
    void Start()
    {
        if (gameover) // sama kuin if ( gameover == true)
        //if (!gameover) // sama kuin if ( gameover == false)
        {
            print(" Gameover ");
        }
        else
        {
            print(" Playing ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (killPlayer)  // sama kuin if (killPlayer == true)
        {
            Destroy(gameObject, 2f); // Gameobject tuhoutuu 2 s viiveen jälkeen
        }
    }
}

