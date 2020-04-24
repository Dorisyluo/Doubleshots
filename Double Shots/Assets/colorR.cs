using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorR : MonoBehaviour
{

    private Material[] rMat;

    public void Start()
    {
        rMat = GetComponent<Renderer>().materials;
        rMat[0].EnableKeyword("_EMISSION");
        rMat[1].EnableKeyword("_EMISSION");

    }
    public void Change(int type)
    {
        if (type == 1)
        {
            rMat[0].SetColor("_EmissionColor", Color.red);
            rMat[1].SetColor("_EmissionColor", Color.red);
        }
        else if (type == 2)
        {
            rMat[0].SetColor("_EmissionColor", Color.yellow);
            rMat[1].SetColor("_EmissionColor", Color.yellow);
        }
        else if (type == 3)
        {
            rMat[0].SetColor("_EmissionColor", Color.blue);
            rMat[1].SetColor("_EmissionColor", Color.blue);
        }
        else if (type == 4)
        {
            rMat[0].SetColor("_EmissionColor", new Color(0.7f, 0.3f, 0f));
            rMat[1].SetColor("_EmissionColor", new Color(0.7f, 0.3f, 0f));
        }
        else if (type == 5)
        {
            rMat[0].SetColor("_EmissionColor", new Color(0.5f, 0f, 0.5f));
            rMat[1].SetColor("_EmissionColor", new Color(0.5f, 0f, 0.5f));
        }
        else if (type == 6)
        {
            rMat[0].SetColor("_EmissionColor", Color.green);
            rMat[1].SetColor("_EmissionColor", Color.green);
        }
    }
    public void Empty()
    {

        rMat[0].SetColor("_EmissionColor", Color.white);
        rMat[1].SetColor("_EmissionColor", Color.white);
    }
}
