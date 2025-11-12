using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject coin; // The object i would like to spawn 

    public int numberToSpawn = 10; // how many coins are spawing 

    public float distanceCoin = 2.0f; // Distance from each coin 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (var i = 0; i < numberToSpawn; i++) // checks if i is less than the number to spawn the do the loop 

        {

            Instantiate(coin, new Vector3(i * distanceCoin, 0, 0), Quaternion.identity); // Instatiate Coin prefab move its postion to x0 y0 z0 keeping roation the same
        }

    }
   

}
