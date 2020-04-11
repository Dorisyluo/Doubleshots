using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Super_Patron_Data : MonoBehaviour
{
    [HideInInspector]
    public string[,] wantedDrinks; //2d arrray
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
    public bool[] phaseSatified;
    [HideInInspector]
    public bool isHostile;
    private string[] drinkList = { "red", "blue", "green", "yellow", "teal", "purple" };
    private void Start()
    {
        
    }
}
