using UnityEngine;

public class DestroyableObject : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Check if the collision is with the player.
        {
           
            Destroy(gameObject);  // Destroy the object.
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
