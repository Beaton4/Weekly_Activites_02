using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week2 : MonoBehaviour
{
    public string myFavouriteGame = "Project Zomboid";
    public int myHoursPlayed = 178;
    public float myCost = 28.95f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My favourite game is" + myFavouriteGame
            + "I have played it for" + myHoursPlayed
            + "It cost me" + myCost
            + "therefore my dollar per hour is:" + ((myCost / (float)myHoursPlayed)));

        float randomValue = Random.Range(1f, 10f); // grabs a random value
        if (randomValue == 1)
        {
            Debug.Log("The Number was one");
        }
        else if (randomValue > 3)
        {
            Debug.Log("The Number was greater than 3");
        }
        else if (randomValue < 3 || randomValue > 5)
        {
            Debug.Log("The number is not 4");
        }
        else if ((randomValue > 1 && randomValue < 5) || randomValue > 5)
        {
            Debug.Log("The number was greater than one and less than 5 or was greater than 5");
        }

        int strength;
        int intelligence;
        int agility;
        int statPool = 20; // my stats

        strength = Random.Range(0, statPool);
        statPool = statPool - strength;
        intelligence = Random.Range(0, statPool);
        statPool = statPool - intelligence;
        agility = Random.Range(0, statPool);
        statPool -= agility;

        Debug.Log("s" + strength + "i" + intelligence + "a" + agility);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
