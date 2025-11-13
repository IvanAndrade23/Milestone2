using UnityEngine;

public class PlayerTargeting : MonoBehaviour
{
    public EnemyManager enemyManager; // Reference to EnemyManager so we can access sortedEnemies
    public float rotationSpeed = 5f;  // How fast the player rotates toward targets
    private int currentIndex = 0;     // Tracks which enemy is targeted
    public float moveSpeed = 5f;      // Walking speed
    private CharacterController controller; // Moves the player smoothly

    void Start()
    {
        // Get the CharacterController component attached to the player
        controller = GetComponent<CharacterController>();

        // If missing, warn the developer
        if (controller == null)
            Debug.LogWarning("No CharacterController found! Add one to your Player.");
    }

    void Update()
    {
        HandleMovement();  // Handle WASD walking
        HandleTargeting(); // Handle enemy switching and rotation
    }

    void HandleMovement()
    {
        // Only move if we actually have a controller
        if (controller == null) return;

        // Get WASD Input (horizontal A/D, vertical W/S)
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Convert input into movement relative to player's facing direction
        Vector3 moveDirection = transform.forward * vertical + transform.right * horizontal;

        // Move controller using Time.deltaTime to make speed frame-rate independent
        controller.Move(moveDirection * moveSpeed * Time.deltaTime);
    }

     void HandleTargeting()
    {
        // Press T to switch to next enemy
        if (Input.GetKeyDown(KeyCode.T))
        {
            currentIndex++;

            // Loop back to first enemy when reaching last
            if (currentIndex >= enemyManager.sortedEnemies.Length)
                currentIndex = 0;

            // Print in console the enemy name plus their Helth sorted inside the array
            Debug.Log("Target switched to: " +                              
                enemyManager.sortedEnemies[currentIndex].gameObject.name +
                " HP: " + enemyManager.sortedEnemies[currentIndex].health); 
        }

        // Choose the first enemy sorted
        EnemyHealth targetEnemy = enemyManager.sortedEnemies[currentIndex];

        // Find direction of the enemy to look
        Vector3 direction = targetEnemy.transform.position - transform.position;
        direction.y = 0;

        // Smothly rotate the camera twards next enemy using time.dealtatime 
        if (direction != Vector3.zero)
        {
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotationSpeed);
        }
    }

}