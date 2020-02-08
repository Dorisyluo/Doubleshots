using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Patron_Patience : MonoBehaviour
{
    private float patience;
    public GameObject patienceUI;
    public Slider patienceSilder;
    // Start is called before the first frame update
    void Start()
    {
        patience = GetComponent<Patron_Data>().secsSeatPatience;
        patienceSilder.maxValue = GetComponent<Patron_Data>().secsSeatPatience;
        patienceSilder.value = GetComponent<Patron_Data>().secsSeatPatience;
        patienceUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Patron_Data>().atSeat && !GetComponent<Patron_Data>().isSatisfied)
        {
            patience -= Time.deltaTime;
            patienceSilder.value = patience;
            patienceUI.SetActive(true);
        }
        noPatience();
  
        
    }

    void noPatience()
    {
        if (patience <= 0)
        {
            GetComponent<Patron_Data>().currentSeat.GetComponent<Occupied>().occupied = false;
            GetComponent<Patron_Data>().isHostile = true;
            Destroy(gameObject);
        }
    }
}
