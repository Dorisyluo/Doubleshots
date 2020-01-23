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
        if (other.CompareTag("Ammo") && other.GetComponent<ShotType>().grabbed == false && loaded == false)
        {
            loadedShot = other.gameObject;
            loadedShot.transform.parent = gameObject.transform;
            loadedShot.transform.localPosition = Vector3.zero;
            loadedShot.GetComponent<Rigidbody>().velocity = Vector3.zero;
            loadedShot.GetComponent<Rigidbody>().useGravity = false;
            loadedShot.GetComponent<CapsuleCollider>().enabled = false;
            loadedShot.transform.localScale = new Vector3(0.05f, 0.01f, 0.05f);
            loadedShot.transform.localRotation = Quaternion.Euler(0, 0, 90);
            loaded = true;
        }
    }
}
