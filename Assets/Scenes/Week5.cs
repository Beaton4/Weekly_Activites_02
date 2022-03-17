using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week5 : MonoBehaviour
{
    private string myName;
    public string Number;
    public string Address;
    public string Email;
    public string PreferredName; 

    public void Setup()
    {
        int randomNumber = Random.Range(0, 2);
        
        if(randomNumber == 0 )
        {
            myName = ""
            Number = ""
            Address = ""

        }

        Debug.Log("My Name is: " + myName
        + "My number is: " + Number
        + "My Address is: " + Address
        + "My Email is: " + Email
        + "My Preferred Name is: " + PreferredName);
    }
}