using JetBrains.Annotations;
using UnityEngine;

public class NumberDisplay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Use a for loop to display numbers from 1 to 10.
        for (int i = 1; i < 10; i++)
        {

            // Display the current number in the Unity console.
            Debug.Log("The current number is " + i);

        }
    }
}
