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
    public GameObject observer;
    public Color[] colorList = new Color[6];
    [HideInInspector]
    public Color currentColor;
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
    private string[] drinkList = { "red", "yellow", "blue", "orange", "purple", "green" };
    //[HideInInspector]
    public List<string> superWanted;
    [HideInInspector]
    public int totalDrinks = 7;
    void Start()
    {
        observer = GameObject.Find("Observer");

        secsSeatPatience = secsSeatPatience / observer.GetComponent<Observer_Data>().difficulty;
        speed = speed * observer.GetComponent<Observer_Data>().difficulty;
        if (super)
        {
            assignDrinks();
            assignColor(superWanted[0]);
        }
        else
        {
            assignColor(wantedDrink);
        }

    }
    void Update(){
        if (super && superWanted.Count > 0)
        {
            assignColor(superWanted[0]);
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
    private void assignColor(string clr)
    {
            switch (clr)
            {
                case "red":
                    currentColor = colorList[0];
                    break;
                case "yellow":
                    currentColor = colorList[1];
                    break;
                case "blue":
                    currentColor = colorList[2];
                    break;
                case "orange":
                    currentColor = colorList[3];
                    break;
                case "purple":
                    currentColor = colorList[4];
                    break;
                case "green":
                    currentColor = colorList[5];
                    break;
                default:
                    currentColor = Color.white;
                        break;
            }
    }
}
