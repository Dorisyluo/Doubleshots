using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : MonoBehaviour
{
    public GameObject newShot;
    public Vector3 spawn;
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(newShot, spawn, Quaternion.identity);
    }
}

