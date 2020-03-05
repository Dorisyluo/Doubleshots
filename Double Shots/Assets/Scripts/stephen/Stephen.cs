using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stephen : MonoBehaviour
{

    public GameObject positionerThing;
    public GameObject annoyingGun;
    public GameObject handThing;
    public float yValueFreeze;

    // Start is called before the first frame update
    void Start()
    {

        
        //stops showing the gun
        annoyingGun.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        //this freezes the camera on y axis cause i got tired of it falling to the ground.
        positionerThing.transform.position = new Vector3(positionerThing.transform.position.x, yValueFreeze, positionerThing.transform.position.z);
    }
}
