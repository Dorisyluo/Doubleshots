using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Super_Color : MonoBehaviour
{
    public GameObject sp;

    private Material patronMat;
    public Material[] allMats;
    void Start()
    {
        patronMat = GetComponent<Renderer>().material;
        allMats = GetComponent<Renderer>().materials;
        patronMat.EnableKeyword("_EMISSION");
        if(allMats.Length > 1)
        {
            allMats[1].SetColor("_EmissionColor", sp.GetComponent<Patron_Data>().currentColor);
        }
        else
        {
            patronMat.SetColor("_EmissionColor", sp.GetComponent<Patron_Data>().currentColor);
        }
        
    }
    private void Update()
    {
        patronMat.EnableKeyword("_EMISSION");
        if (allMats.Length > 1)
        {
            allMats[1].SetColor("_EmissionColor", sp.GetComponent<Patron_Data>().currentColor);
        }
        else
        {
            patronMat.SetColor("_EmissionColor", sp.GetComponent<Patron_Data>().currentColor);
        }

    }

}
