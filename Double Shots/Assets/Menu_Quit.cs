using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Quit : MonoBehaviour
{
    void OnCollisionEnter(Collider collision)
    {
        if (collision.CompareTag("Projectile"))
        {
            Application.Quit();
        }
    }
}
