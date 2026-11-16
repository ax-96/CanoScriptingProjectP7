using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    //creating a public variable that can be accessed by other scripts
    public int apples;
    public int bananas;

    // create 2 private variables that can only be accessed by this script
    private int stapler;
    private int sellotape;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void FruitMachine(int a, int b)

    {
        int answer;
        answer = a + b;
        Debug.Log("The answer is: " + answer);
    }

    private void OfficeSorter(int a, int b)
    {
        int answer;
        answer = a * b;
        Debug.Log("Office Supplies answer is: " + answer);
    }



}
