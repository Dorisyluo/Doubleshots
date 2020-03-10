﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patron_Collide : MonoBehaviour
{
    private GameObject collideObject;
    private int typeCompare;
    private GameObject observer;
    public GameObject correctOrderUI;

    AudioSource audioSource;
    public AudioClip correctOrder, wrongOrder;

    private void Start()
    {
        observer = GameObject.Find("Observer");
        correctOrderUI.SetActive(false);
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
            case "yellow":
                typeCompare = 4;
                break;
            case "pink":
                typeCompare = 5;
                break;
            case "teal":
                typeCompare = 6;
                break;
            default:
                typeCompare = -1;
                break;
        }

        audioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (GetComponent<Patron_Data>().isSatisfied)
        {
            correctOrderUI.SetActive(true);
            
        }
    }
    //doesn't need to be put into update
    private void OnTriggerEnter(Collider ammoCol)
    {
        //grab colision object
        collideObject = ammoCol.gameObject;
        //do something depeding on type

        //check if mans is aggro

        if(collideObject.tag == "Projectile"){
            if (!GetComponent<Patron_Data>().isSatisfied)
            {
                if (collideObject.GetComponent<ShotType>().type == typeCompare)
                {

                    observer.GetComponent<Observer_Data>().score += 10;
                    GetComponent<Patron_Data>().isSatisfied = true;
                    
                    audioSource.PlayOneShot(correctOrder, 0.75f);
                }
                else
                {

                    observer.GetComponent<Observer_Data>().score -= 10;
                    GetComponent<Patron_Data>().isHostile = true;
                    audioSource.PlayOneShot(wrongOrder, 0.75f);
                }
                Destroy(collideObject);
            }


        }
        //else
            //who knows if we need to handle other things colliding

    }




}
