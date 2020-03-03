﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    public GameObject CollidingObject;
    public GameObject objectInHand;

    AudioSource audioSource;

    public void start()
    {
        audioSource = GetComponent<AudioSource>();
    }

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
        else if (CollidingObject.CompareTag("Ammo"))
        {
            //Check to see if this is not called every frame
            audioSource.PlayOneShot(audioSource.clip, 0.7f);
        }
        else
        {
            objectInHand = CollidingObject;
            objectInHand.transform.SetParent(this.transform);
            objectInHand.GetComponent<Rigidbody>().isKinematic = true;
            objectInHand.GetComponent<Rigidbody>().useGravity = false;
            objectInHand.GetComponent<ShotType>().grabbed = true;
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
            objectInHand.GetComponent<Rigidbody>().isKinematic = false;
            objectInHand.GetComponent<Rigidbody>().useGravity = true;
            objectInHand.transform.SetParent(null);
            objectInHand.GetComponent<ShotType>().grabbed = false;
            objectInHand = null;
        }

    }
}

