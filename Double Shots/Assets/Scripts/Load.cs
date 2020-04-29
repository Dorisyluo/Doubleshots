using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour
{
    public bool loadedL;
    public GameObject loadedShotL;
    public bool loadedR;
    public GameObject loadedShotR;
    public GameObject L;
    public GameObject R;
    public GameObject HighL;
    public GameObject HighR;
    public Material O;
    public Material G;
    public Material P;
    public GameObject barrel1;
    public GameObject barrel2;
    public Flip flips;
    private GameObject loadedShot;

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Ammo") && !(loadedL && loadedR) && flips.flipped)
        {
            float distL = Vector3.Distance(other.transform.position, L.transform.position);
            float distR = Vector3.Distance(other.transform.position, R.transform.position);

            if(other.GetComponent<ShotType>().grabbed != false)
            {
                if(distL <= distR)
                {
                    HighL.GetComponent<MeshRenderer>().enabled = true;
                    HighR.GetComponent<MeshRenderer>().enabled = false;
                }
                else
                {
                    HighR.GetComponent<MeshRenderer>().enabled = true;
                    HighL.GetComponent<MeshRenderer>().enabled = false;
                }
            }
            else
            {
                HighL.GetComponent<MeshRenderer>().enabled = false;
                HighR.GetComponent<MeshRenderer>().enabled = false;
                if (distL <= distR && loadedL != true)
                {
                    loadedShotL = other.gameObject;
                    loadedShotL.transform.parent = L.transform;
                    loadedL = true;
                    barrel1.GetComponent<colorL>().Change(loadedShotL.GetComponent<ShotType>().type);
                }
                else if(loadedR != true)
                {
                    loadedShotR = other.gameObject;
                    loadedShotR.transform.parent = R.transform;
                    loadedR = true;
                    barrel2.GetComponent<colorR>().Change(loadedShotR.GetComponent<ShotType>().type);
                }
                loadedShot = other.gameObject;
                loadedShot.transform.localPosition = Vector3.zero;
                loadedShot.GetComponent<Rigidbody>().velocity = Vector3.zero;
                loadedShot.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                loadedShot.GetComponent<Rigidbody>().useGravity = false;
                loadedShot.gameObject.GetComponent<BoxCollider>().enabled = false;
                loadedShot.transform.localScale = new Vector3(0.05f, 0.01f, 0.05f);
                loadedShot.transform.localRotation = Quaternion.Euler(-90, 0, 90);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        HighL.GetComponent<MeshRenderer>().enabled = false;
        HighR.GetComponent<MeshRenderer>().enabled = false;
    }

    public void Mix()
    {
        if(loadedL && loadedR)
        {
            int Ltype = loadedShotL.GetComponent<ShotType>().type;
            int Rtype = loadedShotR.GetComponent<ShotType>().type;

            if ((Ltype == 1 || Rtype == 1) && (Ltype == 2 || Rtype == 2))
            {
                loadedShotL.GetComponent<ShotType>().type = 4;
                loadedShotR.GetComponent<ShotType>().type = 4;
                loadedShotL.GetComponent<Renderer>().material = O;
                loadedShotR.GetComponent<Renderer>().material = O;

            }
            if ((Ltype == 1 || Rtype == 1) && (Ltype == 3 || Rtype == 3))
            {
                loadedShotL.GetComponent<ShotType>().type = 5;
                loadedShotR.GetComponent<ShotType>().type = 5;
                loadedShotL.GetComponent<Renderer>().material = P;
                loadedShotR.GetComponent<Renderer>().material = P;
            }
            if ((Ltype == 3 || Rtype == 3) && (Ltype == 2 || Rtype == 2))
            {
                loadedShotL.GetComponent<ShotType>().type = 6;
                loadedShotR.GetComponent<ShotType>().type = 6;
                loadedShotL.GetComponent<Renderer>().material = G;
                loadedShotR.GetComponent<Renderer>().material = G;
            }
            barrel1.GetComponent<colorL>().Change(loadedShotL.GetComponent<ShotType>().type);
            barrel2.GetComponent<colorR>().Change(loadedShotR.GetComponent<ShotType>().type);
        }       
    }
}
