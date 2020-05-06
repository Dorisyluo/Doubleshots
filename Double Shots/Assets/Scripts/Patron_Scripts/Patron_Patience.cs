using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Patron_Patience : MonoBehaviour
{
    [HideInInspector]
    public float patience;
    public GameObject patienceUI;
    //public Slider patienceSilder;
    public Image[] patienceImage;
    public float wait;
    // Start is called before the first frame update
    void Start()
    {
        patience = GetComponent<Patron_Data>().secsSeatPatience;
        //patienceSilder.maxValue = GetComponent<Patron_Data>().secsSeatPatience;
        //patienceSilder.value = GetComponent<Patron_Data>().secsSeatPatience;
        patienceUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Patron_Data>().atSeat && !GetComponent<Patron_Data>().isSatisfied)
        {
            patience -= Time.deltaTime;
            //patienceSilder.value = patience;
            patienceUI.SetActive(true);
            foreach(Image patienceUI in patienceImage)
            {
                patienceUI.fillAmount -= Time.deltaTime / GetComponent<Patron_Data>().secsSeatPatience;
            }
            
        }
        noPatience();
        if (GetComponent<Patron_Data>().isSatisfied)
        {
            patienceUI.SetActive(false);
        }
        else if (GetComponent<Patron_Data>().isHostile)
        {
            patienceUI.SetActive(false);
            patience = 0;
        }
        
    }

    void noPatience()
    {
        if (patience <= 0)
        {
            GetComponent<Patron_Data>().isHostile = true;
            wait -= Time.deltaTime;
            ////////this check will get removed once a real bullet is added to the gun//////////////////////////
            if(wait <= -3f)
            {
                GetComponent<Patron_Data>().currentSeat.GetComponent<Occupied>().occupied = false;
                Destroy(gameObject);
            }
            
        }
    }
}
