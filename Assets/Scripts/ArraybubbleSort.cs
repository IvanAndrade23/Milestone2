using UnityEngine;

public class ArraybubbleSort : MonoBehaviour
{
    int[] numberArray = { 5, 3, 8, 4, 2 }; // This is me declaring thr array and the values inside

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Debug.Log("Original Array: " + ArrayToString(numberArray)); // Prints text on console saiong Original Arrays and the order is been put into

        BubbleSortArray(numberArray); // Custom method to sort the array using Coin sort

        Debug.Log("Sorted Array: " + ArrayToString(numberArray));
    }

    void BubbleSortArray(int[] array) // This is the custom method for organision the arrays stored from smallest to biggest using a bubble sort 
    {
        int n = array.Length; 
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    // Method that helps convert an array to string 
    string ArrayToString(int[] array) // this means the string the word becomes the integer i have stored in the array
    {
        return string.Join(",", array); // this is the converter that would read my integers into strings 
    }

}
