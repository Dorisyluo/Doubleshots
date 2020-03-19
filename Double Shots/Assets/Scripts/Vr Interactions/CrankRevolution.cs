using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrankRevolution : MonoBehaviour
{
	public CrankGrabTracker grabTracker;
	private float initialPos;
	public HingeJoint hinge;
	private bool reinitialize = true;

	public float halfAngle;
	public bool halfWay;
	public bool revolved;

	//Debug fields
	public float currentVel;
	public float currentPos;
	private int revCount = 0;

	public GameObject green;
	public GameObject red;
	public GameObject blue;

	void start(){
		revolved = false;
	}

	void Update()
	{
		if (grabTracker.isGrabbed) 
		{
			if (reinitialize)
			{
				initialize();
			}

			revolutionTrack();
		} else if (!reinitialize){
			reinitialize = true;
		}
		if (revolved)
		{
			green.GetComponent<ShotType>().respawn();
			red.GetComponent<ShotType>().respawn();
			blue.GetComponent<ShotType>().respawn();
			
			revCount++;
			Debug.Log("Revolution " + revCount);
			revolved = false;
			reinitialize = true;
		}

		currentPos = hinge.angle;
		currentVel = hinge.velocity;
	}

	public void initialize()
	{
		initialPos = hinge.angle;

		halfAngle = initialPos + 180f;
		if (halfAngle > 180) halfAngle -= 360;
		halfWay = false;
		reinitialize = false;
		Debug.Log("Reinitialized");
	}

	public void revolutionTrack()
	{
		if (!halfWay)
		{
			if(hinge.angle + 360f > halfAngle - 15f + 360f && hinge.angle + 360f < halfAngle + 15f + 360f)
			{
				halfWay = true;
			}
			return;
		}
		else{
			if(hinge.angle + 360f > initialPos - 15f + 360f && hinge.angle + 360f < initialPos + 15f + 360f)
			{
				revolved = true;
			}
		}
	}
}