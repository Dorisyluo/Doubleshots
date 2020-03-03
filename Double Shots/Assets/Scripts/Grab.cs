using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    public GameObject CollidingObject;
    public GameObject objectInHand;
    public Transform gripTrans;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ammo") || other.gameObject.CompareTag("Pump"))
        {
            CollidingObject = other.gameObject;

        }
    }

    public void OnTriggerExit(Collider other)
    {
        CollidingObject = null;
    }

    void Update() // refreshing program confirms trigger pressure and determines whether holding or releasing object
    {
        if (Input.GetAxis("Oculus_CrossPlatform_PrimaryHandTrigger") > 0.2f && CollidingObject && objectInHand == null)
        {
            GrabObject();
        }

        if (Input.GetAxis("Oculus_CrossPlatform_PrimaryHandTrigger") < 0.2f && objectInHand)
        {
            ReleaseObject();
        }
    }


    public void GrabObject() //create parentchild relationship between object and hand so object follows hand

    {
        if (CollidingObject.CompareTag("Pump"))
        {
            objectInHand = CollidingObject;
            gameObject.AddComponent<FixedJoint>();
            gameObject.GetComponent<FixedJoint>().connectedBody = CollidingObject.GetComponent<Rigidbody>();
        }
        else
        {
            objectInHand = CollidingObject;
            objectInHand.GetComponent<ShotType>().grabbed = true;
            objectInHand.transform.SetParent(gripTrans);
            objectInHand.transform.localPosition = new Vector3(0, 0, 0);
            objectInHand.transform.localRotation = Quaternion.Euler(0, -30, 90);
            objectInHand.GetComponent<Rigidbody>().isKinematic = true;
            objectInHand.GetComponent<Rigidbody>().useGravity = false;
            
        }

    }


    private void ReleaseObject() //removing parentchild relationship so you drop the object
    {
        if (objectInHand.CompareTag("Pump"))
        {

            Destroy(gameObject.GetComponent<FixedJoint>());
            objectInHand = null;
        }
        else
        {
            objectInHand.GetComponent<ShotType>().grabbed = false;
            objectInHand.GetComponent<Rigidbody>().isKinematic = false;
            objectInHand.GetComponent<Rigidbody>().useGravity = true;
            objectInHand.transform.SetParent(null);            
            objectInHand = null;
        }

    }
}

