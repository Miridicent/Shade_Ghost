using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Player switches scenes upon entering the trigger of the object this script is assinged to
public class Side1_Enter : MonoBehaviour
{
    public string sceneManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneManager);
        }
    }
}
