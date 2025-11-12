using UnityEngine;
using System.Collections.Generic;

public class ListInsertionSort : MonoBehaviour
{
    List<int> numberList = new List<int> { 7, 1, 9, 6, 0 }; // this is me declerain my list as integers whole numbers

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Original List: " + ListToString(numberList)); // Prints The list of numbers stored on to the console 

        InsertionSortList(numberList); //calls the method to organise the list by order from smallest to biggest

        Debug.Log("Sort List: " + ListToString(numberList));  // Prints out sorted list using the method bellow 
    }

    void InsertionSortList(List<int> list) // Method on how to organisde them in order from smallest to largest
    {
        int n = list.Count;
        for (int i = 1; i < n; i++)
        {
            int key = list[i];
            int j = i - 1;

            while (j >= 0 && list[j] > key)
            {
                list[j + 1] = list[j];
                j = j - 1;
            }
            list[j + 1] = key;
        }
    }

    // Method that helps convert a List to string 
    string ListToString(List<int> List)
    {
         return string.Join(", ", List);
    }
}
