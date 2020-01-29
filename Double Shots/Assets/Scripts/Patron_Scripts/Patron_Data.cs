using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patron_Data : MonoBehaviour
{
    public string[] drinkList = {"red", "blue", "green", "purple" };
    //set this value in editor
    public float secsSeatPatience;
    public GameObject currentSeat;
    public bool atSeat;
    public bool atPool;
}
