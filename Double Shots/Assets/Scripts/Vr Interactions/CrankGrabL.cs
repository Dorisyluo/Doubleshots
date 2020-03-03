using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrankGrabL : MonoBehaviour
{
		public GameObject CollidingObject;
        public GameObject objectInHand;
        public GameObject parent;
        public CrankGrabTracker grabTracker;

        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Handle"))
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
            if (Input.GetAxis("Oculus_CrossPlatform_PrimaryHandTrigger") > 0.2f && CollidingObject)
            {
                GrabObject();
            }

            if ((Input.GetAxis("Oculus_CrossPlatform_PrimaryHandTrigger") < 0.2f && objectInHand))
            {
                ReleaseObject();
            }
            if (grabTracker.releaseMe)
            {
                ReleaseObject();
                grabTracker.releaseMe = false;
            }
        }


        public void GrabObject() //create parentchild relationship between object and hand so object follows hand

        {
                objectInHand = CollidingObject;
                gameObject.AddComponent<FixedJoint>();
                gameObject.GetComponent<FixedJoint>().connectedBody = CollidingObject.GetComponent<Rigidbody>();
                grabTracker.isGrabbed = true;
        }


        private void ReleaseObject() //removing parentchild relationship so you drop the object
        {
                Destroy(gameObject.GetComponent<FixedJoint>());
                objectInHand = null;
                grabTracker.isGrabbed = false;

        }
}