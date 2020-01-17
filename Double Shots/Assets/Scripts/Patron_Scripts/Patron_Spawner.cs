using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patron_Spawner : MonoBehaviour
{
    public GameObject patron;
    public bool stopSpawning = false;
    public float secSpawnTime;
    public float secSpawnDelay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPatron", secSpawnTime, secSpawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnPatron()
    {
        Instantiate(patron, transform.position, transform.rotation);
        if (stopSpawning)
        {
            CancelInvoke("SpawnPatron");
        }
    }
}
