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
        R = 0;
        G = 0;
        B = 0;
        if (type == 1 || type == 4 || type == 5)
        {
            R = 1;
        }
        if (type == 2 || type == 4 || type == 6)
        {
            G = 1;
        }
        if (type == 3 || type == 5 || type == 6)
        {
            B = 1;
        }
        rMat[0].SetColor("_EmissionColor", new Color(R, G, B));
        rMat[1].SetColor("_EmissionColor", new Color(R, G, B));
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
