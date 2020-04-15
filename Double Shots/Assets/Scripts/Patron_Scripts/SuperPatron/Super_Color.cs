using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Super_Color : MonoBehaviour
{
    public GameObject sp;
    public int R;
    public int G;
    public int B;
    private Material patronMat;
    public Material[] allMats;
    void Start()
    {
        getColor();
        patronMat = GetComponent<Renderer>().material;
        allMats = GetComponent<Renderer>().materials;
        patronMat.EnableKeyword("_EMISSION");
        if(allMats.Length > 1)
        {
            allMats[1].SetColor("_EmissionColor", new Color(R, G, B));
        }
        else
        {
            patronMat.SetColor("_EmissionColor", new Color(R, G, B));
        }
        
    }
    private void Update()
    {
        getColor();
        patronMat.EnableKeyword("_EMISSION");
        if (allMats.Length > 1)
        {
            allMats[1].SetColor("_EmissionColor", new Color(R, G, B));
        }
        else
        {
            patronMat.SetColor("_EmissionColor", new Color(R, G, B));
        }

    }

    void getColor()
    {
        switch (sp.GetComponent<Patron_Data>().superWanted[0])
        {
            case "red":
                R = 1;
                G = 0;
                B = 0;
                break;
            case "green":
                R = 0;
                G = 1;
                B = 0;
                break;
            case "blue":
                R = 0;
                G = 0;
                B = 1;
                break;
            case "yellow":
                R = 1;
                G = 1;
                B = 0;
                break;
            case "pink":
                R = 1;
                G = 0;
                B = 1;
                break;
            case "teal":
                R = 0;
                G = 1;
                B = 1;
                break;
            default:
                R = 1;
                G = 1;
                B = 1;
                break;
        }
    }
}
