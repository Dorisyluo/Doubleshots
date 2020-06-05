using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Quit : MonoBehaviour
{
    void OnTriggernEnter(Collider collision)
    {
        if (collision.CompareTag("Projectile"))
        {
            Application.Quit();
        }
    }
}
