using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject projectile;
    public GameObject Load;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) > 0.0f)
        {
            if(Load.GetComponent<LoadL>().loaded == true)
            {
                GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody>().AddForce(transform.right * -1000);
                Load.GetComponent<LoadL>().loaded = false;
                Destroy(Load.GetComponent<LoadL>().loadedShot);
            }
            
        }
    }
}
