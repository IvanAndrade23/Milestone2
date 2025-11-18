using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class StateMachine : MonoBehaviour // Class Name for Reference 
{
    public Transform player; // I Can add my player here 
    public float speed = 3f; // Enemy walk speed, can be changed in ispector 
    public float chaseDistance = 5.0f; // Enemy distance to player to trigger chase 
    public float attackDistance = 1.0f; // Enemy Distance to attack you and when collided you die 
    public GameManager gameManager; 


    public enum State // This Enum represents the different States, the StateMachine script can be in 
    {
        StateA, //Patrol Idle 
        StateB, //If player reaches close to the Enemy chase Player
        StateC, //If Enemy is really close to player Attack player and when colided with player, end scene 
    }

    private State currentState; // This varible will be used to store and track current state of the state machine 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentState = State.StateA; // Initial State when game starts 

    }

    // Update is called once per frame
     void Update()
    {
        
            ChangeState(); 
        
    }

    public void ChangeState() // Change State mehtod 
    {
        switch (currentState) // check the current state and perform actions listed.
        {
            case State.StateA:
                Debug.Log("Enemy is Idleling"); // When in State A print Message In State A

                float distance = Vector3.Distance(transform.position, player.position); // if closed enough to the player switch to StateB chase
                if (distance <= chaseDistance)
                {
                    Debug.Log("Player is close enough");
                    currentState = State.StateB; // state A now is State B
                }

                break;

            case State.StateB: // when in State B chase the player using its tranform postion with time * timedeltatime
                Debug.Log("Enemy is Chasing the Player");

                transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime); // Move towards the player

                transform.LookAt(player.position); // face the player 

                if (Vector3.Distance(transform.position, player.position) < chaseDistance) // if close enough to the player switch to stateC Attack
                { 
                    currentState = State.StateC; // State B is Now Statce C
                }

                break;

            case State.StateC:
                Debug.Log("Enemy is Attacking you"); // When in State A print Message In State C

                if (Vector3.Distance(transform.position, player.position) > attackDistance)
                {
                    currentState = State.StateB;                
                }

                break;

        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (currentState == State.StateC) // when current state is State C 
        {
            if (collision.gameObject.CompareTag("Player")) // and if colided with player  tell GameManerS to chance scene
            {
                Debug.Log("The Enemy has hit you");

                SceneManager.LoadScene("Menu"); // Load the scene Menu 
            }
        }
    }

}
