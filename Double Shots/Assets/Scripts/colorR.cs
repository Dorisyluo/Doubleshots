using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorR : MonoBehaviour
{
    private int R;
    private int G;
    private int B;
    private Material[] rMat;

    public void Start()
    {
        rMat = GetComponent<Renderer>().materials;
        rMat[0].EnableKeyword("_EMISSION");
        rMat[1].EnableKeyword("_EMISSION");
        R = 0;
        G = 0;
        B = 0;
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
            rMat[0].SetColor("_EmissionColor", new Color(1, 0.5f, 0));
            rMat[1].SetColor("_EmissionColor", new Color(1, 0.5f, 0));

        }
        else if (type == 5)
        {
            rMat[0].SetColor("_EmissionColor", Color.magenta);
            rMat[1].SetColor("_EmissionColor", Color.magenta);
        }
        else if (type == 6)
        {
            rMat[0].SetColor("_EmissionColor", Color.green);
            rMat[1].SetColor("_EmissionColor", Color.green);
        }
        else if (type == 0)
        {
            rMat[0].SetColor("_EmissionColor", Color.black);
            rMat[1].SetColor("_EmissionColor", Color.black);
        }
    }
    public void Empty()
    {
        R = 1;
        G = 1;
        B = 1;
        rMat[0].SetColor("_EmissionColor", new Color(R, G, B));
        rMat[1].SetColor("_EmissionColor", new Color(R, G, B));
    }
}
