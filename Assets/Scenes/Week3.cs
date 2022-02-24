using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week3 : MonoBehaviour
{
    public string myName = " Bailey Eaton ";
    public int myAge = 19;
    public int ageInMonths = 12;
    public int ageInDays = 365;
    public int ageInWeeks = 52;
    public int ageInHours = 24;
    public int ageInMinutes = 60;
    public int ageInSeconds = 60;
    private void Multiply(int myAge, int theYearSince)
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(" My Name Is " + myName
            + " My Age Is " + myAge);

        // months
        ageInMonths = myAge * 12;
        Debug.Log(ageInMonths);
        //weeks
        ageInWeeks = myAge * ageInWeeks;
        Debug.Log(ageInWeeks);
        // days
        ageInDays = myAge * ageInDays;
        // hours
        ageInHours = myAge *

        // mins

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
