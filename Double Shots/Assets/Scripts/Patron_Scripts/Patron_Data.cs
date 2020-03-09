using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patron_Data : MonoBehaviour
{
    //set these in editor
    public string wantedDrink;
    public float secsSeatPatience;
    public float speed;
    public bool special;
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
}
