using UnityEngine;

public class CoinMovement : MonoBehaviour
{
    public float moveSpeed = 1.0f; // Movement speeed of the object

    public float amplitude = 1.0f; //Altitude of the object 

    private Vector3 startPos; // The initial positon of the object 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position; // sote the initial positon of the object 
    }

    // Update is called once per frame
    void Update()
    {
        float verticalMovemnt = Mathf.Sin(Time.time * moveSpeed) * amplitude; //  Using Math.sin it will calculate the vertical movement. Time.time is a value that will inrease over time so this will create a smother oscillation

        Vector3 newPositon = startPos + Vector3.up * verticalMovemnt; // Uptdate the objects positon by adding the vertical movement of its original position 

        transform.position = newPositon; // update the object

    }
}
