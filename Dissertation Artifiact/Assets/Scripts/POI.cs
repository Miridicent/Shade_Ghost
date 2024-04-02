using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POI : MonoBehaviour
{
    new public GameObject gameObject;

    private void OnTriggerEnter2D(Collider2D other)
    {
        gameObject.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        gameObject.SetActive(false);
    }
}
