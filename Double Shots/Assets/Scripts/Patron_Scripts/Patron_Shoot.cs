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
                Vector3 shoot = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
                bullet = Instantiate(projectile, shoot, Quaternion.identity) as GameObject;
            }
            notShot = false;

        }
        
    }
}
