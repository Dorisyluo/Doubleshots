using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Patron_Patience : MonoBehaviour
{
    private float patience;
    public GameObject patienceUI;
    public Slider patienceSilder;
    public Image patienceImage;
    public float wait;
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
            //patienceImage.fillAmount -= Time.deltaTime/GetComponent<Patron_Data>().secsSeatPatience;
        }
        noPatience();
        if (GetComponent<Patron_Data>().isSatisfied)
        {
            patienceUI.SetActive(false);
        }
        
    }

    void noPatience()
    {
        if (patience <= 0)
        {
                
            wait -= Time.deltaTime;
            if(wait <= 0)
            {
                //Sound/Voice Line here
                GetComponent<Patron_Data>().isHostile = true;  
            }
            if(wait <= -2f)
            {
                GetComponent<Patron_Data>().currentSeat.GetComponent<Occupied>().occupied = false;
                Destroy(gameObject);
            }
            
        }
    }
}
