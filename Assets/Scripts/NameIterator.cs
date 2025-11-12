using UnityEngine;

public class NameIterator : MonoBehaviour
{
    private string[] names = { "Ivan", "Player 1", "Player 2", "Player 3" }; // This is where all my strings name is stored 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (string name in names)
        {

            Debug.Log("Name: " + name); //Displays each name on the console
        }
    }

}
