using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wizard : MonoBehaviour
{
    int max;
    int min;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        max = 1000;
        min = 1;
        guess = 500;
       
        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number...");
        Debug.Log("the highest number you can pick is" + max);
        Debug.Log("the lowest number you can pick is" + min);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)){
           Debug.Log("W was pressed");
            min = guess;
            NextGuess();
           
        }
         else if(Input.GetKeyDown(KeyCode.S)){
            Debug.Log("S was pressed");
             max = guess;
             NextGuess();
           
        }

         else if(Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("I guessed right");
            
        }
        
    }
     void NextGuess()
    {
        guess = (max + min) / 2;
         Debug.Log("Is it higher or lower than..." + guess);
    }
}
