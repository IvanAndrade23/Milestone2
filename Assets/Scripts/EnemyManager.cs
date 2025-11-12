using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement; // Adding scenemanager it will load everyting on the scene manager 
using System.Collections;

public class EnemyManager : MonoBehaviour
{
    // The array will store the enemies after sorting.
    // Player script will read from this method.
    public EnemyHealth[] sortedEnemies;

    void Start()
    {
        // Get all objects in the scene that have the EnemyHealth component.
        // This gives us our full enemy list BEFORE sorting.
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

        // Bubble Sort (Lowest → Highest)
        for (int i = 0; i < sortedEnemies.Length - 1; i++)
        {
            for (int j = 0; j < sortedEnemies.Length - i - 1; j++)
            {
                // If one enemy has more HP than the next, swap them until the largest health is at the end.
                if (sortedEnemies[j].health > sortedEnemies[j + 1].health)
                {
                    EnemyHealth temp = sortedEnemies[j];
                    sortedEnemies[j] = sortedEnemies[j + 1];
                    sortedEnemies[j + 1] = temp;
                }
            }
        }
        // Print sorted list using Debug
        Debug.Log(" Enemies Sorted by HP (Lowest → Highest) ");
        foreach (EnemyHealth e in sortedEnemies)
        {
            Debug.Log(e.gameObject.name + " HP: " + e.health);
        }
    }
}
