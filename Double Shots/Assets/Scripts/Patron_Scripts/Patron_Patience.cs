using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patron_Patience : MonoBehaviour
{
    public float patience = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Patron_Data>().atSeat)
        {
            patience -= Time.deltaTime;
        }
        noPatience();
  
        
    }

    void noPatience()
    {
        if (patience <= 0)
        {
            GetComponent<Patron_Data>().currentSeat.GetComponent<Occupied>().occupied = false;
            Destroy(gameObject);
        }
    }
}
