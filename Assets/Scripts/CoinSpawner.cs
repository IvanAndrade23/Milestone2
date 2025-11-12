using UnityEngine;

public class CoinSpawner : MonoBehaviour
    
{
    public GameObject coinPrefab; // This is where the engine will get my coin from 

    public GameObject[] coins; // this is where you can store all your coins 

    void Start()
    {
        coins = new GameObject[10]; //when the game starts this will automaticaly spawn 10 coins 

        
       Instantiate(coinPrefab, new Vector3(0, 0, 0), Quaternion.identity);  // This is the postion on where the coins will spawn in this case they will spawn next to each other 

    }

}
