using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    public bool flipped;
    public Transform hammer;
    // Update is called once per frame
    private void Start()
    {
        flipped = false;
    }
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickDown) && !flipped)
        {
            flipped = true;
            transform.RotateAround(hammer.position, transform.forward, 40);
            hammer.Rotate(0, 0, -30f, Space.Self);
        }
        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickUp) && flipped)
        {
            flipped = false;
            transform.RotateAround(hammer.position, transform.forward, -40);
            hammer.Rotate(0, 0, 30f, Space.Self);
        }
    }
}
