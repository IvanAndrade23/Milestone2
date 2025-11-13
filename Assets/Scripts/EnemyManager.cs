using UnityEngine;
using UnityEngine.SceneManagement; // Adding scenemanager it will load everyting on the scene manager 
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering.Universal;

public class EnemyManager : MonoBehaviour
{
    // The array will store the enemies after sorting.
    // Player script will read from this method.
    public EnemyHealth[] sortedEnemies;
    private int CollectedCoin = 0; // this value is automatically set to 0 b


    public void AddCollectedCoin(int amout)  // Call this method when a coin is collected 
    {
        CollectedCoin += amout;        //Add the int given to collecect Coin

        if (CollectedCoin >= 1)       //Check is collectedcoin reaches 1
        {
            SceneManager.LoadScene("Menu"); // Load the scene you created 
            Debug.Log("All Coins are collected, End Game!"); // Print message on Console
        }
    }

    void Start()
    {
        // Get all objects in the scene that have the EnemyHealth component.
        // This will find all enemies in scene list before sorting.
        sortedEnemies = FindObjectsByType<EnemyHealth>(FindObjectsSortMode.None);


        // After Findig all enemies it prints out in console each enemy HP value using Foreach 
        Debug.Log(" Enemies HP Values ");
        foreach (EnemyHealth enemy in sortedEnemies)
        {
            Debug.Log(enemy.gameObject.name + " HP: " + enemy.health);
        }


        // Create an array to store only the HP values
        float[] hpValues = new float[sortedEnemies.Length];

        for (int i = 0; i < sortedEnemies.Length; i++)
        {
            hpValues[i] = sortedEnemies[i].health;
        }

        // Bubble Sort (Lowest - Highest)
        for (int i = 0; i < sortedEnemies.Length - 1; i++)
        {
            for (int j = 0; j < sortedEnemies.Length - i - 1; j++)
            {
                // Checks two ememies values, if one enemy has more HP than the next, swap them, do again for the next two enemies until the largest health is at the end.
                if (sortedEnemies[j].health > sortedEnemies[j + 1].health)
                {
                    EnemyHealth temp = sortedEnemies[j];
                    sortedEnemies[j] = sortedEnemies[j + 1];
                    sortedEnemies[j + 1] = temp;
                }
            }
        }
        // Print sorted list using Debug
        Debug.Log(" Enemies Sorted by HP (Lowest - Highest) ");
        foreach (EnemyHealth e in sortedEnemies)
        {
            Debug.Log(e.gameObject.name + " HP: " + e.health);
        }
    }
}
