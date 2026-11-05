using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoops : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        string[] strings = new string[3];

        //give each element in the array a value
        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";

        foreach (string str in strings)
        {
            Debug.Log(str);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
