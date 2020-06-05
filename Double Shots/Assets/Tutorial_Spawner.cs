using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_Spawner : MonoBehaviour
{
    public GameObject[] patrons;
    public bool stopSpawning = false;
    public float secSpawnDelay;
    public float initialDelay;
    public GameObject[] chairs;
    private GameObject observer;
    private bool red;
    private bool purple;
    //private GameObject timer;
    //rivate int choice;
    // Start is called before the first frame update
    void Start()
    {
        observer = GameObject.Find("Observer");
        red = false;
        purple = false;
        //timer = GameObject.Find("Timer");
        //StartCoroutine(spawnPatron());
    }

    // Update is called once per frame
    void Update()
    {
        initialDelay -= Time.deltaTime;

        if(initialDelay <= 0 && red == false)
        {
            Instantiate(patrons[0], transform.position, transform.rotation);
            patrons[0].GetComponent<Path_To>().agent.Warp(transform.position);
            red = true;
            initialDelay = 15;
        }else if(initialDelay <=0 && red == true && purple == false)
        {
            Instantiate(patrons[1], transform.position, transform.rotation);
            patrons[1].GetComponent<Path_To>().agent.Warp(transform.position);
            purple = true;
        }
        /*chairs = observer.GetComponent<Observer_Data>().openSeats;
        if (chairs.Length <= 0)
        {
            stopSpawning = true;
        }
        else
        {
            stopSpawning = false;
        }*/
    }
    /*IEnumerator spawnPatron()
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


    }*/
}

