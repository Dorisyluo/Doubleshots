using System.Collections;
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
            index = Random.Range(0, chairs.Length);
        }
        GetComponent<Patron_Data>().currentSeat = chairs[index];
        targetChair = new Vector3(chairs[index].transform.position.x, transform.position.y, chairs[index].transform.position.z);

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


    }
    void moveToSeat()
    {
       
        
        if (Mathf.Abs(transform.position.x - targetChair.x) < 0.01f && Mathf.Abs(transform.position.z - targetChair.z) < 0.01f)
        {
            chairs[index].GetComponent<Occupied>().occupied = true;
            agent.isStopped = true;
            GetComponent<Patron_Data>().atSeat = true;
        }

       else if (chairs.Length > 0)
        {
            agent.SetDestination(targetChair);
        }
    }

    void moveToDoor()
    {
        agent.SetDestination(doorLocation);

        if (Mathf.Abs(transform.position.x - doorLocation.x) < 0.01f && Mathf.Abs(transform.position.z - doorLocation.z) < 0.01f)
        {
            entered = true;
        }
    }
}