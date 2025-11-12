using UnityEngine;

public class CoinCheck : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) // When Coin Collides with other (Player)
    {
        if (other.CompareTag("Player")) // 
        {
            CoinCount playerCounter = other.GetComponent<CoinCount>(); // Finds the Coin Count script 

            GameManager gameManager = FindAnyObjectByType<GameManager>();  // Finds the gameManger Scricpt and all it 

            if (gameManager != null)
            {
                gameManager.AddCollectedCoin(1); // Adds collect coins Until reached its set target to load up nect scene
            }

            if (playerCounter != null) 
            {
                playerCounter.IncrementCoinCount(); // Adds collect coinds to the player and then deletes it once collected
                Destroy(gameObject);
            }
            else
            {
                Debug.LogError("Error: Player is missing the CoinCount script"); //Print this message if script is missing 
            }
        }
    }
    



}
