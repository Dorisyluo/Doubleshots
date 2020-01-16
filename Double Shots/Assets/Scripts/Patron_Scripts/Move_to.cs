using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_to : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] chairs;
    public float speed;
    private int index;
    private GameObject targetChair;
    // Update is called once per frame
    void Start()
    {
        chairs = GameObject.FindGameObjectsWithTag("Seat");
        index = Random.Range(0, chairs.Length);
        targetChair = chairs[index];
    }
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(targetChair.transform.position.x,transform.position.y, targetChair.transform.position.z), step);
       
    }

}