using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatronAnimation : MonoBehaviour
{
    private Vector3 previousPosition;
    public float curspeed;
    private float idleChange;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        InvokeRepeating("idle", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 curMove = transform.position - previousPosition;
        curspeed = curMove.magnitude / Time.deltaTime;
        previousPosition = transform.position;

        anim.SetFloat("Speed", curspeed);
        Debug.Log("Animator Speed: " + anim.GetFloat("Speed"));
     
    }

    void idle()
    {
        idleChange = Random.Range(0.0f, 10.0f);
        anim.SetFloat("IdleChange", idleChange);
    }
}
