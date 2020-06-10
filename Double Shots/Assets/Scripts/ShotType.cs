using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotType : MonoBehaviour
{
    public bool grabbed;
    private bool spawned;
    public int type;
    private Vector3 currentPos;
    private Quaternion rotation;
    // Start is called before the first frame update
    void Start()
    {
        grabbed = false;
        spawned = false;
        currentPos = this.transform.position;
        rotation = Quaternion.Euler(-90, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(grabbed && !spawned)
        {
            Instantiate(this.gameObject, currentPos, rotation);
            spawned = true;
        }else if(!grabbed && spawned)
        {
            spawned = false;
            
        }
    }
}
