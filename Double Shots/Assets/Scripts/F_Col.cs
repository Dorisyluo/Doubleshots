using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_Col : MonoBehaviour
{
    public GameObject pump;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pump"))
        {
            pump.GetComponent<Pumper>().pU = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Pump"))
        {
            pump.GetComponent<Pumper>().pU = false;
        }
    }
}
