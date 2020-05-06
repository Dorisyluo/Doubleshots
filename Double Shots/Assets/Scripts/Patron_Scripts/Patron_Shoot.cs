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
            Invoke("shoot", 2f);

        }
        
    }
    private void shoot()
    {
        if (notShot)
        {
            gunShot.PlayOneShot(gunShot.clip, 0.7f);
            Vector3 shoot = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
            bullet = Instantiate(projectile, shoot, Quaternion.identity) as GameObject;
        }
        notShot = false;
    }
}
