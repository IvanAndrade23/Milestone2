using UnityEngine;

public class CoinCount : MonoBehaviour
{
  
    
   private int CoinCollected = 0; // This is will be Coin collected counter

        void Start()
        {
            Debug.Log("Coin Counter Initialized. Start Count: " + CoinCollected); // if coding is corect when start debug messege will come up saying the following message, This value will start as 0
        }
        public void IncrementCoinCount()
        
        {
            CoinCollected = CoinCollected + 1;
            Debug.Log("Coin collected! New Total: " + CoinCollected);  // when a new coin gets collected a new coin adds to the counter and a new message on debug console will apear with the new coin added 
    }
    
}
