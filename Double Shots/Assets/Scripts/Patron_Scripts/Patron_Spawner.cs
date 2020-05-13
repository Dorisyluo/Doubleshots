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
    private GameObject timer;
    private int choice;
    // Start is called before the first frame update
    void Start()
    {
        observer = GameObject.Find("Observer");
        timer = GameObject.Find("Timer");
        StartCoroutine(spawnPatron());
    }

    // Update is called once per frame
    void Update()
    {
        initialDelay -= Time.deltaTime;
        chairs = observer.GetComponent<Observer_Data>().openSeats;
        if (chairs.Length <= 0 || timer.GetComponent<Countdown>().timesUp)
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
                    patrons[choice].GetComponent<Path_To>().agent.Warp(transform.position);
                }

                yield return new WaitForSeconds(secSpawnDelay);
            
        }
        
        
    }
}
