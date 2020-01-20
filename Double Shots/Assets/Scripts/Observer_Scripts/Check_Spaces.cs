using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check_Spaces : MonoBehaviour
{
    public GameObject[] chairs;
    public GameObject[] pool1;
    public GameObject[] pool2;
    public GameObject[] openChairs;

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
        openChairs = validChairs.ToArray();
    }

    public void getPool1()
    {
        //return open spaces in pool 1
    }

    public void getPool2()
    {
        //return open spaces in pool 2
    }
}
