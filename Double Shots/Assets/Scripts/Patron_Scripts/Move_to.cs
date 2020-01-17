using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_To : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] chairs;
    public float speed = 5;
    private int index = 0;
    private GameObject targetChair;
    private bool targetFound = false;
    // Update is called once per frame
    void Start()
    {
        chairs = GameObject.FindGameObjectsWithTag("Seat");
        for(;index < chairs.Length; index++)
        {
            if (!chairs[index].GetComponent<Occupied>().occupied)
            {
                Debug.Log(chairs[index] + " " + index);
                targetFound = true;
                break;
            }
            
        }
        if (targetFound)
        {
            targetChair = chairs[index];
        }
        
    }
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (targetFound && !chairs[index].GetComponent<Occupied>().occupied)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(targetChair.transform.position.x, transform.position.y, targetChair.transform.position.z), step);
        }
        if (Mathf.Abs(transform.position.x - targetChair.transform.position.x) < 0.01f && Mathf.Abs(transform.position.z - targetChair.transform.position.z) < 0.01f)
        {
            chairs[index].GetComponent<Occupied>().occupied = true;
        }
    }

}