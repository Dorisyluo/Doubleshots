﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Path_To : MonoBehaviour
{

    public GameObject[] chairs;
    private int index;
    private Vector3 targetChair;
    private Vector3 doorLocation;
    private GameObject door;
    private GameObject observer;
    public bool entered;
    public NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        

        door = GameObject.Find("Entrance");
        observer = GameObject.Find("Observer");
        doorLocation = new Vector3(door.transform.position.x, transform.position.y, door.transform.position.z);
        chairs = observer.GetComponent<Observer_Data>().openSeats;
        if (chairs.Length > 0)
        {
            index = 0;
            chairs[index].GetComponent<Occupied>().occupied = true;
        }
        GetComponent<Patron_Data>().currentSeat = chairs[index];
        targetChair = new Vector3(chairs[index].transform.position.x, transform.position.y, chairs[index].transform.position.z);
        agent.speed = GetComponent<Patron_Data>().speed;

    }

    // Update is called once per frame
    void Update()
    {
        if (!entered)
        {
            moveToDoor();
        }
        else if (entered)
        {
            moveToSeat();
        }
        if (GetComponent<Patron_Data>().isSatisfied)
        {
            exit();
        }
    }
    void moveToSeat()
    {
       if (chairs.Length > 0)
       {
            agent.SetDestination(targetChair);
       }
    }

    void moveToDoor()
    {
        agent.SetDestination(doorLocation);

    }

    void exit()
    {
        agent.SetDestination(doorLocation);
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject colObj = other.gameObject;
        if (colObj.tag == "Door")
        {
            if (!entered)
            {
                entered = true;
            }
            if (entered && GetComponent<Patron_Data>().isSatisfied)
            {
                GetComponent<Patron_Data>().currentSeat.GetComponent<Occupied>().occupied = false;
                Destroy(gameObject);
            }
        }

        if (colObj.tag == "Seat")
        {
            if (!GetComponent<Patron_Data>().isSatisfied)
            {
                agent.isStopped = true;
            }
            else
            {
                agent.isStopped = false;
            }

            GetComponent<Patron_Data>().atSeat = true;
        }

    }
}