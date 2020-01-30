﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    private GameObject projectile;
    public GameObject shotR;
    public GameObject shotG;
    public GameObject shotB;
    public GameObject Load;
    private Load Loader;
    private bool fired;
    // Start is called before the first frame update
    void Start()
    {
        Loader = Load.GetComponent<Load>();
        fired = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) > 0.5f && fired == false)
        {
            fired = true;
            if(Loader.loadedL)
            {
                int projType = Loader.loadedShotL.GetComponent<ShotType>().type;
                if(projType == 1)
                {
                    projectile = shotR;
                }else if(projType == 2)
                {
                    projectile = shotG;
                }
                else 
                {
                    projectile = shotB;
                }
                GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody>().AddForce(transform.right * -1000);
                Loader.loadedL = false;
                Destroy(Loader.loadedShotL);
            }
            else if(Loader.loadedR){
                int projType = Loader.loadedShotR.GetComponent<ShotType>().type;
                if (projType == 1)
                {
                    projectile = shotR;
                }
                else if (projType == 2)
                {
                    projectile = shotG;
                }
                else
                {
                    projectile = shotB;
                }
                GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody>().AddForce(transform.right * -1000);
                Loader.loadedR = false;
                Destroy(Loader.loadedShotR);
            }
            else
            {
                //play gun clicking sound
            }            
        }
        if (OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) < 0.1f && fired !=false)
        {
            fired = false;
        }
    }
}
