using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Super_Patron_Data : MonoBehaviour
{
    [HideInInspector]
    public string[] wantedDrinks;
    public int totalDrinks = 7;
    public float secsSeatPatience;
    public float speed;
    [HideInInspector]
    public GameObject currentSeat;
    [HideInInspector]
    public bool atSeat;
    [HideInInspector]
    public bool atPool;
    [HideInInspector]
    public bool isSatisfied;
    public bool[] phaseSatified = new bool[3];
    [HideInInspector]
    public bool isHostile;
    private string[] drinkList = { "red", "blue", "green", "yellow", "teal", "purple"};
    void Start()
    {
        assignDrinks();
    }
    private void Update()
    {
        Debug.Log(wantedDrinks);
    }
    private void assignDrinks()
    {
        for(int i = 0; i < totalDrinks; i++)
        {
            if(i < 2)
            {
                wantedDrinks.SetValue(drinkList[Random.Range(0, 3)], i);
            }
            else if (i < 4)
            {
                wantedDrinks.SetValue(drinkList[Random.Range(3, 6)], i);
            }
            else
            {
                wantedDrinks.SetValue(drinkList[Random.Range(0, 6)], i);
            }
            
        }
    }
}
