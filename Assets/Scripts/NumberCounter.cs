using UnityEngine;

public class NumberCounter : MonoBehaviour
{
    public int targetNumber = 10;

    private int currentNumber = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Use a while loop to count from 1 to the target number.
        while (currentNumber <= targetNumber)
        {
            // Display the current number in the Unity console.
            Debug.Log("Number: " + currentNumber);

            currentNumber++; // Increment the current number for the next iteration.
        }
          
    }
}
