using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnFunction : MonoBehaviour
{
    public int number;
    public string MyName;
    // Start is called before the first frame update
    void Start()
    {
        int returnedNumber = GiveDouble();
        print(returnedNumber);

        PrintName(MyName);
    }

    int GiveDouble()
    {
        return (number * 2);
    }

    void PrintName(string name)
    {
        print(" My name is " + name);
    }



}

