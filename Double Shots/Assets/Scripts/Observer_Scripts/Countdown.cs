using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Countdown : MonoBehaviour
{
    public float secSetTime;
    public TextMeshPro timeText;
    public GameObject spawner;
    public GameObject observer;
    public bool timesUp;
    void Start()
    {
        spawner = GameObject.Find("Patron_Spawner");
        observer = GameObject.Find("Observer");
        StartCoroutine(increaseDifficulty());
    }
    // Update is called once per frame
    void Update()
    {
        if(spawner.GetComponent<Patron_Spawner>().initialDelay <= 0)
        {
            secSetTime -= Time.deltaTime;         
            
            if (secSetTime > 0)
            {
                int minutes = (int)(secSetTime / 60);
                int seconds = (int)(secSetTime % 60);

                timeText.text = string.Format("{0:0}:{1:00}", minutes, seconds);

                

            }
            else
            {
                timesUp = true;
            }
        }
    }
    IEnumerator increaseDifficulty(){
        for(; ; )
        {
            if(spawner.GetComponent<Patron_Spawner>().initialDelay <= 0)
            {
                observer.GetComponent<Observer_Data>().difficulty += .1f;
                yield return new WaitForSeconds(observer.GetComponent<Observer_Data>().difficultySecStep);
            }
           
           yield return new WaitForSeconds(spawner.GetComponent<Patron_Spawner>().initialDelay+ observer.GetComponent<Observer_Data>().difficultySecStep);
        }
       

        
    }
}
