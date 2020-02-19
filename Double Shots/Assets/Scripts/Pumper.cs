using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumper : MonoBehaviour
{
    public bool pD;
    public bool pU;
    private bool flagD;
    private int pumps;
    public GameObject Load;
    // Start is called before the first frame update
    void Start()
    {
        pD = false;
        pU = false;
        flagD = false;
        pumps = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Load.GetComponent<Load>().loadedL && Load.GetComponent<Load>().loadedR)
        {
            if (pD && flagD == false)
            {
                pumps++;
                flagD = true;
            }
            if (pU && flagD == true)
            {
                pumps++;
                flagD = false;
            }
            if (pumps >= 5)
            {
                pumps = 0;
                Load.GetComponent<Load>().Mix();
            }
        }

    }
}
