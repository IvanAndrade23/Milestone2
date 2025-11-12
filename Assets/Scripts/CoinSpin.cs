using UnityEngine;

public class CoinSpin : MonoBehaviour
{
    public float rotationSpeed = 50f; // The roation speed of the Coin 

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);  //this mean continuasly rotate Coin in the speed stated  

    }
}
