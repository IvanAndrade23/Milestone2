using UnityEngine;

public class ThirdCamera : MonoBehaviour
{
    public Transform target; // camera to follow the target 

    public float distance = 5.0f; // Distance to player 

    public float sensitivity = 2.0f;   // Sensitibity 

    public float heightOfset = 1.5f;   //  height of the offset camera

    public float rotationX = 0.0f; // Initial vertical rotation

    public float rotationY = 0.0f; // Initial Horizontal rotation 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // locks cursor to the middle of the screen 
        Cursor.visible = false;  // makes cursor invisible 

    }

    // Update is called once per frame
    void Update()
    {
        HandleCameraInput(); 
       
    }

    void HandleCameraInput()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity; // Rotate camera based on mouse input X axis
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity; // Rotate camera based on mouse input Y axis 

        rotationX += mouseX; // update camera horizontal rotation based on inpput 

        rotationY += mouseY; // update camera vertical rotation based on mouse input 

        rotationX = Mathf.Clamp(rotationX, -90, 90); // clamp the vertical rotation so it does not go -+90 thats its maximun values

        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0); // apply the camera rotation 

    }

    void LateUpdate()
    {
        FollowTarget();

    }

    void FollowTarget() // This finds the position of the target then positon of the target - target foward as i want the camera behind the player then distance i want to be slightly above player 
    {
        Vector3 targetPosition = target.position - target.forward * distance + Vector3.up * heightOfset; //Heightoffset so i can adjust the height in editor 

        transform.position = targetPosition; // changes the positon of object where script is attached 

    }


}
