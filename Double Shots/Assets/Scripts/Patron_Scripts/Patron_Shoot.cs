using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patron_Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projectile;
    private bool notShot = true;
    private GameObject bullet;

    AudioSource gunShot;

    void Start()
    {
        gunShot = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Patron_Data>().isHostile)
        {
            if (notShot)
            {
                //Sound here prob
               gunShot.PlayOneShot(gunShot.clip, 0.7f);
                bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
            }
            notShot = false;

        }
        
    }
}
