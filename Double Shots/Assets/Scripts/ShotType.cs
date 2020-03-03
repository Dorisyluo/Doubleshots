using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotType : MonoBehaviour
{
    public bool grabbed;
    private bool spawned;
    public int type;
    // Start is called before the first frame update
    void Start()
    {
        grabbed = false;
        spawned = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(grabbed && !spawned)
        {
            Instantiate(this.gameObject, new Vector3(Random.Range(-1f,1f),1.35f,-16f), Quaternion.identity);
            spawned = true;
        }else if(!grabbed && spawned)
        {
            spawned = false;
        }
    }
}
