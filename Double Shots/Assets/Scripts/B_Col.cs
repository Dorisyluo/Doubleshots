using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_Col : MonoBehaviour
{
    public GameObject pump;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pump"))
        {
            pump.GetComponent<Pumper>().pD = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Pump"))
        {
            pump.GetComponent<Pumper>().pD = false;
        }
    }
}
