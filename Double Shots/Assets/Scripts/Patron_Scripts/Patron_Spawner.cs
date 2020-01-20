﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patron_Spawner : MonoBehaviour
{
    public GameObject patron;
    public bool stopSpawning = false;
    public float secSpawnTime;
    public float secSpawnDelay;
    public GameObject[] chairs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPatron", secSpawnTime, secSpawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        chairs = GetComponent<Check_Spaces>().openChairs;
        if (chairs.Length <= 0)
        {
            CancelInvoke("SpawnPatron");
            stopSpawning = true;
        }
    }
    public void SpawnPatron()
    {
        if (stopSpawning)
        {
            CancelInvoke("SpawnPatron");
        }
        Instantiate(patron, transform.position, transform.rotation);
        
        
    }
}
