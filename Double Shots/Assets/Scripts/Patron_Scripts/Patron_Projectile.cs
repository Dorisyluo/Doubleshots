using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patron_Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public float projectileSpeed;
    private GameObject collideObject;
    private GameObject observer;
    private Vector3 playerPosition;
    void Start()
    {
        observer = GameObject.Find("Observer");
        player = GameObject.FindGameObjectsWithTag("Player")[0];
        playerPosition = player.transform.position;
        transform.rotation = Quaternion.LookRotation((playerPosition - transform.position).normalized);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, projectileSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        collideObject = collision.gameObject;
        if(collideObject == player)
        {
            Destroy(gameObject);
            observer.GetComponent<Observer_Data>().gameOver = true;
        }
        
    }
}
