using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    private GameObject projectile;
    public GameObject shotR;
    public GameObject shotG;
    public GameObject shotB;
    public GameObject shotY;
    public GameObject shotP;
    public GameObject shotT;
    public GameObject Load;
    public GameObject barrel1;
    public GameObject barrel2;
    private Load Loader;
    private bool fired;

    AudioSource gunShot;
    public AudioClip emptyGun;
    // Start is called before the first frame update
    void Start()
    {
        Loader = Load.GetComponent<Load>();
        fired = false;

        gunShot = GetComponent<AudioSource>();
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
                else if (projType == 3)
                {
                    projectile = shotB;
                }
                else if (projType == 4)
                {
                    projectile = shotY;

                }
                else if (projType == 5)
                {
                    projectile = shotP;
                }
                else if (projType == 6)
                {
                    projectile = shotT;
                }

                gunShot.PlayOneShot(gunShot.clip, 0.7f);
                GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody>().AddForce(transform.right * -1000);
                Loader.loadedL = false;
                Destroy(Loader.loadedShotL);
                barrel1.GetComponent<colorL>().Empty();

                if (projType == 4 || projType == 5 || projType == 6)
                {
                    Loader.loadedR = false;
                    Destroy(Loader.loadedShotR);
                    barrel2.GetComponent<colorR>().Empty();
                }
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

                gunShot.PlayOneShot(gunShot.clip, 0.7f);
                GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody>().AddForce(transform.right * -1000);
                Loader.loadedR = false;
                Destroy(Loader.loadedShotR);
                barrel2.GetComponent<colorR>().Empty();
            }
            else
            {
                //play gun clicking sound
                gunShot.PlayOneShot(emptyGun, 0.7f);
            }            
        }
        if (OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) < 0.1f && fired !=false)
        {
            fired = false;
        }
    }
}
