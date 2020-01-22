using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_To : MonoBehaviour
{

    public GameObject[] chairs;
    public float speed = 5;
    private int index = 1;
    private Vector3 targetChair;
    private Vector3 doorLocation;
    private GameObject door;
    private GameObject observer;
    public bool entered;

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
        float moveSpeed = speed * Time.deltaTime;
        if (!entered)
        {
            moveToDoor(moveSpeed);
        }
        else if (entered)
        {
            moveToSeat(moveSpeed);
        }


    }
    void moveToSeat(float step)
    {
        if (chairs.Length > 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetChair, step);
        }

        if (Mathf.Abs(transform.position.x - targetChair.x) < 0.01f && Mathf.Abs(transform.position.z - targetChair.z) < 0.01f)
        {
            chairs[index].GetComponent<Occupied>().occupied = true;
            GetComponent<Patron_Data>().atSeat = true;
        }
    }

    void moveToDoor(float step)
    {
        transform.position = Vector3.MoveTowards(transform.position, doorLocation, step);

        if (Mathf.Abs(transform.position.x - doorLocation.x) < 0.01f && Mathf.Abs(transform.position.z - doorLocation.z) < 0.01f)
        {
            entered = true;
        }
    }
}