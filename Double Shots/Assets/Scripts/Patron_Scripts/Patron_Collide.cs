using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patron_Collide : MonoBehaviour
{
    private GameObject collideObject;
    private int typeCompare;
    private GameObject observer;
    // Update is called once per frame
    private void Start()
    {
        observer = GameObject.Find("Observer");
        switch (GetComponent<Patron_Data>().wantedDrink)
        {
            case "red":
                typeCompare = 1;
                break;
            case "green":
                typeCompare = 2;
                break;
            case "blue":
                typeCompare = 3;
                break;
            default:
                typeCompare = -1;
                break;
        }
    }

    //doesn't need to be put into update
    private void OnTriggerStay(Collider ammoCol)
    {
        //grab colision object
        collideObject = ammoCol.gameObject;
        //do something depeding on type

        //check if mans is aggro

        if(collideObject.tag == "Projectile"){
            
            if(collideObject.GetComponent<ShotType>().type == typeCompare)
            {
                observer.GetComponent<Observer_Data>().score += 10;
                Debug.Log("Patron Satisfied");
            }
            else
            {
                observer.GetComponent<Observer_Data>().score -= 10;
                Debug.Log("Oops");
            }
            Destroy(collideObject);


        }
        //else
            //who knows if we need to handle other things colliding

    }




}
