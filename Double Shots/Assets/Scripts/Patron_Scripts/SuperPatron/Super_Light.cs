using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Super_Light : MonoBehaviour
{

    public Light lt;
    // Start is called before the first frame update
    void Start()
    {
        lt.color = GetComponent<Patron_Data>().currentColor;
    }

    // Update is called once per frame
    void Update()
    {
        lt.color = GetComponent<Patron_Data>().currentColor;
    }
}
