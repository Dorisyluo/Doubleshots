using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_Start : MonoBehaviour
{
    void OnCollisionEnter(Collider collision)
    {
        if (collision.CompareTag("Projectile"))
        {
            SceneManager.LoadScene("Main_Scene");
        }
    }
}
