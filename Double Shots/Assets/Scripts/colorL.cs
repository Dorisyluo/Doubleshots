using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorL : MonoBehaviour
{
    private int R;
    private int Y;
    private int B;
    private Material[] lMat;

    public void Start()
    {
        lMat = GetComponent<Renderer>().materials;
        lMat[0].EnableKeyword("_EMISSION");
        lMat[1].EnableKeyword("_EMISSION");
        R = 0;
        Y = 0;
        B = 0;
    }
    public void Change(int type)
    {
        if (type == 1)
        {
            lMat[0].SetColor("_EmissionColor", Color.red);
            lMat[1].SetColor("_EmissionColor", Color.red);
        }
        else if (type == 2)
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
            lMat[0].SetColor("_EmissionColor", new Color(1, 1.92f, 0.016f));
            lMat[1].SetColor("_EmissionColor", new Color(1, 1.92f, 0.016f));

        }
        else if (type == 5)
        {
            lMat[0].SetColor("_EmissionColor", Color.magenta);
            lMat[1].SetColor("_EmissionColor", Color.magenta);
        }
        else if (type == 6)
        {
            lMat[0].SetColor("_EmissionColor", Color.green);
            lMat[1].SetColor("_EmissionColor", Color.green);
        }
        else if (type == 0)
        {
            lMat[0].SetColor("_EmissionColor", Color.black);
            lMat[1].SetColor("_EmissionColor", Color.black);
        }
    }
    public void Empty()
    {
        R = 1;
        Y = 1;
        B = 1;
        lMat[0].SetColor("_EmissionColor", new Color(R, Y, B));
        lMat[1].SetColor("_EmissionColor", new Color(R, Y, B));
    }
}
