using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour
{
    public bool loadedL;
    public GameObject loadedShotL;
    public bool loadedR;
    public GameObject loadedShotR;
    public GameObject L;
    public GameObject R;
    public GameObject HighL;
    public GameObject HighR;
    private GameObject loadedShot;
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
        if (other.CompareTag("Ammo") && !(loadedL && loadedR))
        {
            float distL = Vector3.Distance(other.transform.position, L.transform.position);
            float distR = Vector3.Distance(other.transform.position, R.transform.position);

            if(other.GetComponent<ShotType>().grabbed != false)
            {
                if(distL <= distR)
                {
                    HighL.GetComponent<MeshRenderer>().enabled = true;
                    HighR.GetComponent<MeshRenderer>().enabled = false;
                }
                else
                {
                    HighR.GetComponent<MeshRenderer>().enabled = true;
                    HighL.GetComponent<MeshRenderer>().enabled = false;
                }
            }
            else
            {
                HighL.GetComponent<MeshRenderer>().enabled = false;
                HighR.GetComponent<MeshRenderer>().enabled = false;
                if (distL <= distR && loadedL != true)
                {
                    loadedShotL = other.gameObject;
                    loadedShotL.transform.parent = L.transform;
                    loadedL = true;
                }
                else
                {
                    loadedShotR = other.gameObject;
                    loadedShotR.transform.parent = R.transform;
                    loadedR = true;
                }
                loadedShot = other.gameObject;
                loadedShot.transform.localPosition = Vector3.zero;
                loadedShot.GetComponent<Rigidbody>().velocity = Vector3.zero;
                loadedShot.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                loadedShot.GetComponent<Rigidbody>().useGravity = false;
                loadedShot.gameObject.GetComponent<CapsuleCollider>().enabled = false;
                loadedShot.transform.localScale = new Vector3(0.05f, 0.01f, 0.05f);
                loadedShot.transform.localRotation = Quaternion.Euler(0, 0, 90);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        HighL.GetComponent<MeshRenderer>().enabled = false;
        HighR.GetComponent<MeshRenderer>().enabled = false;
    }
}
