using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrankGrabTracker : MonoBehaviour
{
	public bool isGrabbed;
	public bool releaseMe;
	public Rigidbody mRigid;

	void start()
	{
		mRigid.constraints = RigidbodyConstraints.None;
	}

	void Update()
	{
		if (isGrabbed){
			mRigid.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ;
		} else 
		{
			mRigid.constraints = RigidbodyConstraints.FreezePositionZ;
		}
	}
}