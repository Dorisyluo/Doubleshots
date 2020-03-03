using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleConstraint : MonoBehaviour
{
	public CrankGrabTracker grabTracker;
	private float xPos;
	private float zPos;
	private float contraint = 4.25f;
	private float releaseThreshold = 6.3f;

	void LateUpdate()
	{
		xPos = gameObject.GetComponent<Transform>().localPosition.x;
		zPos = gameObject.GetComponent<Transform>().localPosition.z + 0.5f;

		if (xPos > contraint)
		{
			if (xPos > releaseThreshold)
			{
				grabTracker.releaseMe = true;
				return;
			}
			transform.localPosition = new Vector3(contraint, transform.localPosition.y, transform.localPosition.z);
		}
		if (xPos < -contraint)
		{
			if (xPos < -releaseThreshold)
			{
				grabTracker.releaseMe = true;
				return;
			}
			transform.localPosition = new Vector3(-contraint, transform.localPosition.y, transform.localPosition.z);
		}
		if (zPos > contraint)
		{
			if (zPos > releaseThreshold)
			{
				grabTracker.releaseMe = true;
				return;
			}
			transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, contraint);
		}
		if (zPos < -contraint)
		{
			if (zPos < -releaseThreshold)
			{
				grabTracker.releaseMe = true;
				return;
			}
			transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, -contraint);
		}
	}
}