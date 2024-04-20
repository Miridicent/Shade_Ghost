using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
   
    public Transform targetLocation;

   // when the player touches something with the spike tag they will be sent back to the start
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Spike"))
        {
            // Move the object instantly to the target location
            transform.position = targetLocation.position;
        }
    }
}
