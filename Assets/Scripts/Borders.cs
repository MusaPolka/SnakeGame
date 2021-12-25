using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Borders : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainSnake"))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }
}
