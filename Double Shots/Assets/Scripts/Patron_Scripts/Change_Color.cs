using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Color : MonoBehaviour
{
    // Start is called before the first frame update
    public int R;
    public int G;
    public int B;
    void Start()
    {
        Material patronMat = GetComponent<Renderer>().material;
        patronMat.EnableKeyword("_EMISSION");
        patronMat.SetColor("_EmissionColor", new Color(R,G,B));
    }
}
