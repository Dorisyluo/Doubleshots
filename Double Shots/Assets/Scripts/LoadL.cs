using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadL : MonoBehaviour
{
    public bool loaded;
    public GameObject loadedShot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Ammo") && other.GetComponent<ShotType>().grabbed == false)
        {
            loadedShot = other.gameObject;
            loadedShot.transform.parent = gameObject.transform;
            loadedShot.GetComponent<Rigidbody>().velocity = Vector3.zero;
            loadedShot.GetComponent<CapsuleCollider>().enabled = false;
            loaded = true;
        }
    }
}
