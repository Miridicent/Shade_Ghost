using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//When the pendent enters the end trigger then the latch puzzle is complete 
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
