using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Diagnostics.DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class ColorChanger : MonoBehaviour
{

    int myInt = 5;
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(myInt);
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    private int MultiplyByTwo(int myInt)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {

    }

    int MultiplyingByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}