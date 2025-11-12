using UnityEngine;
using UnityEngine.SceneManagement; // Adding scenemanager it will load everyting on the scene manager 
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering.Universal;

public class GameManager : MonoBehaviour
{
    public GameObject pausemenu; 

    private int CollectedCoin = 0; // this value is automatically set to 0 b
       
    private bool isPause = false; // Pause Menu

    public void AddCollectedCoin(int amout)  // Call this method when a coin is collected 
    {
        CollectedCoin += amout;        //Add the int given to collecect Coin

        if (CollectedCoin >= 10)       //Check is collectedcoin reaches 10
        {
            SceneManager.LoadScene("Data Algorithm"); // Load the scene you created 
            Debug.Log("All Coins are collected, Loading Next Level!");
        }
    }
    // Update is called once per frame
    void Update()
        {
            if (Input.GetKeyDown(KeyCode.P)) // When a player presses P 
            {
                TogglePausemenu(); //  when P is pressed Open Pause Menu 
            }

            Pause();
        }

    public void TogglePausemenu() 
    {
        pausemenu.SetActive(!pausemenu.activeSelf); // Swaps betwen active and inactive of a game object Menu 

    }
    void Pause()
    {
        if (Input.GetKeyDown(KeyCode.P))  // When pressed P the game pauses 
        {
            if (isPause)    // if Pause is pressed and is true pause the game and let it acess to the 
            {
                Time.timeScale = 1.0f;  // unpause the game
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
            else    //  if pause is pressed and its false
            {
                Time.timeScale = 0.0f;  // Pause the game 
                Cursor.lockState = CursorLockMode.None;  
                Cursor.visible = true;
            }
             
            isPause = !isPause; // Set bool to false 

        }
    }

    public void NewLevelBtn(string Menu)
    {
        SceneManager.LoadScene(Menu); // Loads new scene called Menu that i have created  
    }

    public void ExitGameBtn()
    {
        Application.Quit(); // Exit the game 
    }

    public void FlowOfTime() // This code if for the Menu, when its pause the in game time should freeze when the menu is open.
    {
        if (isPause)
        {
            Time.timeScale = 1.0f;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Time.timeScale = 0.0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        isPause = !isPause;
    }
}
