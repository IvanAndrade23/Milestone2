using UnityEngine;

public class License : MonoBehaviour
{
    // This is where ill set my methods 
    string driverName; 
    int age; 
    bool passed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        driverName = "Ivan"; // Driver name as been set to Ivan as a string
        age = 27;   // The Age will my integer whole number 
        passed = false; 

        {
            Debug.Log(driverName + " is " + age + " years old! Welcome back");
        }

        if (passed == true) // If the divers nage is okay then just print this message
        {
            Debug.Log(driverName + " Can get a full drivers license");
        }
        else if (age >= 17) // if the drivers name is bigger or equal to the number then say this message 
        {
            Debug.Log(driverName + " Is Old enough to get a provisional Licence!");  
        }
        else // if the drivers age is not more equal or to he number stated 17 then say this message 
        {
            Debug.Log(driverName + " Is under 17, And is too young to get a license"); 
        }

    }

}
