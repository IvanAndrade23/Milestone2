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
}
