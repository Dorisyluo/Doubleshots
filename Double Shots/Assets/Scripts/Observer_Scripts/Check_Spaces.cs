using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check_Spaces : MonoBehaviour
{
    private GameObject[] chairs;
    private GameObject[] pool1;
    private GameObject[] pool2;

    // Start is called before the first frame update
    void Start()
    {
        chairs = GameObject.FindGameObjectsWithTag("Seat");
        getChairs();
    }

    // Update is called once per frame
    void Update()
    {
        getChairs();
    }

    public void getChairs()
    {
        List<GameObject> validChairs = new List<GameObject>();
        for (int index = 0; index < chairs.Length; index++)
        {
            if (!chairs[index].GetComponent<Occupied>().occupied)
            {
                validChairs.Add(chairs[index]);
            }

        }    
        GetComponent<Observer_Data>().openSeats = validChairs.ToArray();
    }

    //******We don't know how the "pools" look and work yet*****//
    public void getPool1()
    {
        //return open spaces in pool 1
    }

    public void getPool2()
    {
        //return open spaces in pool 2
    }
}
