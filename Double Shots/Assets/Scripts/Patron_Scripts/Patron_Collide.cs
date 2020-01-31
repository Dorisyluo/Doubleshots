using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patron_Collide : MonoBehaviour
{
    private GameObject collideObject;
    private int typeCompare;
    // Update is called once per frame
    private void Start()
    {
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
    private void OnCollisionEnter (Collision ammoCol)
    {
        //grab colision object
        collideObject = ammoCol.gameObject;
        //do something depeding on type

        //check if mans is aggro

        if(collideObject.tag == "Projectile"){
            if(collideObject.GetComponent<ShotType>().type == typeCompare)
            {
                Debug.Log("Patron Satisfied");
            }
            else
            {
                Debug.Log("Oops");
            }


        }
        //else
            //who knows if we need to handle other things colliding

    }




}
