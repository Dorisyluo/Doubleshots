using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    private GameObject projectile;
    public GameObject shotR;
    public GameObject shotG;
    public GameObject shotB;
    public GameObject Load;
    private LoadL LoadedL;
    // Start is called before the first frame update
    void Start()
    {
        LoadedL = Load.GetComponent<LoadL>();

    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) > 0.0f)
        {
            if(LoadedL.loaded)
            {
                int projType = LoadedL.loadedShot.GetComponent<ShotType>().type;
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
                LoadedL.loaded = false;
                Destroy(LoadedL.loadedShot);
            }            
        }
    }
}
