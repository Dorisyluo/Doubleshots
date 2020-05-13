using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patron_Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projectile;
    private GameObject bullet;
    public float secsRepeatTimer;

    AudioSource gunShot;

    void Start()
    {
        gunShot = GetComponent<AudioSource>();
        StartCoroutine(shoot());
    }
    // Update is called once per frame
    void Update()
    {
    
    }
    IEnumerator shoot()
    {

        for(; ; )
        {
            if (GetComponent<Patron_Data>().isHostile)
            {
                gunShot.PlayOneShot(gunShot.clip, 0.7f);
                Vector3 shoot = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
                bullet = Instantiate(projectile, shoot, Quaternion.identity) as GameObject;
            }
            yield return new WaitForSeconds(secsRepeatTimer);
        }           
            
    }
}
