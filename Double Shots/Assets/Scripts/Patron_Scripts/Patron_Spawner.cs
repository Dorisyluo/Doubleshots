using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patron_Spawner : MonoBehaviour
{
    public GameObject[] patrons;
    public bool stopSpawning = false;
    public float secSpawnDelay;
    public float initialDelay;
    public GameObject[] chairs;
    private GameObject observer;
    private int choice;
    // Start is called before the first frame update
    void Start()
    {
        observer = GameObject.Find("Observer");
        StartCoroutine(spawnPatron());
    }

    // Update is called once per frame
    void Update()
    {
        initialDelay -= Time.deltaTime;
        chairs = observer.GetComponent<Observer_Data>().openSeats;
        if (chairs.Length <= 0)
        {
            stopSpawning = true;
        }
        else
        {
            stopSpawning = false;
        }
    }
    IEnumerator spawnPatron()
    {
            for (; ; )
            {
                if (!stopSpawning && initialDelay <= 0)
                {
                    choice = Random.Range(0, patrons.Length);
                    Instantiate(patrons[choice], transform.position, transform.rotation);
                }

                yield return new WaitForSeconds(secSpawnDelay);
            
        }
        
        
    }
}
