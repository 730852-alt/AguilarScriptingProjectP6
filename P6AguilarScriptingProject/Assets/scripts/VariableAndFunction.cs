using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableAndFunction : MonoBehaviour
{
    //create an integer variable
   public int myInt = 5; 

    // Start is called before the first frame update
    void Start()
    {
        //run the varible through my fuction
        myInt = MultiplyByTwo(myInt);

        //display the result in the console
        Debug.Log(myInt); 
    }

    // Update is called once per frame
    void Update()
    {
        
    
    }

    //creating my fuction
    int MultiplyByTwo(int number)
    {
        //create a results variable 
        int result;
        result = number * 2;

        //return the result
        return result;
    }

}
