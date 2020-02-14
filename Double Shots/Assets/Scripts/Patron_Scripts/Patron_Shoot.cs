using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patron_Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projectile;
    private bool notShot = true;
    private GameObject bullet;
    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Patron_Data>().isHostile)
        {
            if (notShot)
            {
                //Sound here prob
                bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
            }
            notShot = false;

        }
        
    }
}
