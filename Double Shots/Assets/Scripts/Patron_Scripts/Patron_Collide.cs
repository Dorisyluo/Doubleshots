using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patron_Collide : MonoBehaviour
{
    private GameObject collideObject;
    // Update is called once per frame
    void Update()
    {
 
    }

    //doesn't need to be put into update
    private void OnCollisionEnter (Collision ammoCol)
    {
        //grab colision object
        collideObject = ammoCol.gameObject;
        //do something depeding on type

        //check if mans is aggro

        //if(ammo name is same a wanted drink)
            //points, and stuff
        //else
            //

    }




}
