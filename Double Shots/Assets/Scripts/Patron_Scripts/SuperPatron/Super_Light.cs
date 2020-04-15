using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Super_Light : MonoBehaviour
{
    public int R;
    public int G;
    public int B;
    public Light lt;
    // Start is called before the first frame update
    void Start()
    {
        getColor();
        lt.color = new Color(R,G,B);
    }

    // Update is called once per frame
    void Update()
    {
        getColor();
        lt.color = new Color(R, G, B);
    }
    void getColor()
    {
        switch (GetComponent<Patron_Data>().superWanted[0])
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
