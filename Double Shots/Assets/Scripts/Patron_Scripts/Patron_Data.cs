using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patron_Data : MonoBehaviour
{
    //set these in editor
    public string wantedDrink;
    public float secsSeatPatience;
    public float speed;
    public bool super;
    [HideInInspector]
    public GameObject currentSeat;
    [HideInInspector]
    public bool atSeat;
    [HideInInspector]
    public bool atPool;
    [HideInInspector]
    public bool isSatisfied;
    [HideInInspector]
    public bool isHostile;
    private string[] drinkList = { "red", "blue", "green", "yellow", "teal", "pink" };
    //[HideInInspector]
    public List<string> superWanted;
    [HideInInspector]
    public int totalDrinks = 7;
    void Start()
    {
        if (super) 
        {
            assignDrinks();
        }
        
    }
    private void assignDrinks()
    {
        for (int i = 0; i < totalDrinks; i++)
        {
            if (i < 2)
            {
                superWanted.Add(drinkList[Random.Range(0, 3)]);
            }
            else if (i < 4)
            {
                superWanted.Add(drinkList[Random.Range(3, 6)]);
            }
            else
            {
                superWanted.Add(drinkList[Random.Range(0, 6)]);
            }

        }
    }
}
