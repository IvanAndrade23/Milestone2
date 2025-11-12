using UnityEngine;

public class EvenOddChecker : MonoBehaviour
{
    public int numberToCheck = 2;   // This is where ill put my integer in 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Check if the number is even or odd using an if statement.
        if (numberToCheck % 2 == 0)
        {
            Debug.Log(numberToCheck + " is even."); // If number to check is even print this messega
        }
        else
        {
            Debug.Log(numberToCheck + " is odd."); // If number to check is not even the its Oddd this message will come up on the console 

        }
        
    }
}
