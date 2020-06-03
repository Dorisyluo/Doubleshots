using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Return : MonoBehaviour
{
    void OnCollisionEnter(Collider collision)
    {
        if (collision.CompareTag("Projectile"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
