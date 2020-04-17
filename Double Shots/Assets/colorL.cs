using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorL : MonoBehaviour
{

    private Material[] lMat;

    public void Start()
    {
        lMat = GetComponent<Renderer>().materials;
        lMat[0].EnableKeyword("_EMISSION");
        lMat[1].EnableKeyword("_EMISSION");

    }
    public void Change(int type)
    {

        if (type == 1)
        {
            lMat[0].SetColor("_EmissionColor", Color.red);
            lMat[1].SetColor("_EmissionColor", Color.red);
        }
        else if(type == 2)
        {
            lMat[0].SetColor("_EmissionColor", Color.yellow);
            lMat[1].SetColor("_EmissionColor", Color.yellow);
        }
        else if (type == 3)
        {
            lMat[0].SetColor("_EmissionColor", Color.blue);
            lMat[1].SetColor("_EmissionColor", Color.blue);
        }
        else if (type == 4)
        {
            lMat[0].SetColor("_EmissionColor", new Color(0.5f, 0.3f, 0f));
            lMat[1].SetColor("_EmissionColor", new Color(0.5f, 0.3f, 0f));
        }
        else if (type == 5)
        {
            lMat[0].SetColor("_EmissionColor", Color.green);
            lMat[1].SetColor("_EmissionColor", Color.green);
        }
        else if (type == 6)
        {
            lMat[0].SetColor("_EmissionColor", new Color(0.5f, 0f, 0.5f));
            lMat[1].SetColor("_EmissionColor", new Color(0.5f, 0f, 0.5f));
        }

    }
    public void Empty()
    {

        lMat[0].SetColor("_EmissionColor", Color.white);
        lMat[1].SetColor("_EmissionColor", Color.white);
    }
}
