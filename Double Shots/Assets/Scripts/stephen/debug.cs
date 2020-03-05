using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debug : MonoBehaviour
{

    public GameObject positionerThing;
    public GameObject annoyingGun;
    public GameObject handThing;
    public float yValueFreeze;

    // Start is called before the first frame update
    void Start()
    {
         
        positionerThing.transform.position = pPosition;
        //stops showing the gun
        annoyingGun.setActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        //this freezes the camera on y axis cause i got tired of it falling to the ground.
        pPosition = new Vector3(pPoisition.x, yValueFreeze, pPoisition.z);
    }
}
