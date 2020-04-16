using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotType : MonoBehaviour
{
    public bool grabbed;
    private bool spawned;
    public int type;
    private Vector3 currentPos;
    // Start is called before the first frame update
    void Start()
    {
        grabbed = false;
        spawned = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(grabbed && !spawned)
        {
        	//respawn();
            spawned = true;
        }else if(!grabbed && spawned)
        {
            spawned = false;
        }
    }

    public void respawn(){
    	if (type == 1){
        	currentPos = new Vector3(-0.405f, 1.282f, -16.08f);
        } else if (type == 2){
        	currentPos = new Vector3(-0.005f, 1.2604f, -16.02213f);
       	} else if (type == 3){
       		currentPos = new Vector3(0.548f, 1.289f, -16.159f);
       	}
    	Instantiate(this.gameObject, currentPos, Quaternion.identity);
    }
}
