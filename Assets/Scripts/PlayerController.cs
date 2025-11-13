using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5.0f;          // Movement speed 
    public float mouseSensitivity = 2.0f;       // Mouse Sensitivity 

    private float verticalRotation = 0;         // Vertical Rotation 
    private Rigidbody rb;                       // Checks the physics of the character  


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();  // Gets the RijidBody of object 

        Cursor.lockState = CursorLockMode.Locked; // Lock the cursor to the game windon 

    }

    // Update is called once per frame
    void Update()
    {

            RotationImputM(); // Call this method every frame so we have smoth camera movement 

            WASD(); // Call this method every frame so we have smoth player movement 

    }

    void RotationImputM()
    {

        float horizontalRoatation = Input.GetAxis("Mouse X") * mouseSensitivity;  //Grabs the player horizontal rotaion and xby mouse sensitivity

        transform.Rotate(0, horizontalRoatation, 0); //  

        verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity; // needs to be assigned to object so it rotates that way

        verticalRotation = Mathf.Clamp(verticalRotation, -90, 90); // Use Clamp to limit your rotaions, So it wont go more than +-90

        Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0); // Grabsa the camera and makes sure its rotation is matched with verical Roation 

    }

    void WASD()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // takes the horizontal input from WASD or arrow keys 

        float moveVertical = Input.GetAxis("Vertical"); // takes vetical input from WASD or arrow Keys 

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical) * movementSpeed * Time.deltaTime; // Multiples that value by movement spee and time 

        movement = transform.TransformDirection(movement); // makes sure the direction is corect 

        rb.linearVelocity = new Vector3(movement.x, rb.linearVelocity.y, movement.z); // Sets the velocity only for the rigidbody 

    }


}
