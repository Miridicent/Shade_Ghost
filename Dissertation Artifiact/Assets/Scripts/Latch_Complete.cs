using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Latch_Complete : MonoBehaviour
{
    Pendent_holder Pendent_holder;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Pendent_holder.Pendent++;
            SceneManager.LoadScene("Side_1");
        }
    }
}
