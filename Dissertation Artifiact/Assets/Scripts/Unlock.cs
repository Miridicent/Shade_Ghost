using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock : MonoBehaviour
{
    public string targetTag = "";
    public GameObject targetGameObject;
    public int unCount = 0;
    

   
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag(targetTag) && Input.GetMouseButtonUp(0))
        {
            // Perform actions when the specified object enters the trigger
            Debug.Log("Trigger entered by object with tag: " + targetTag);
            targetGameObject.SetActive(false);
            unCount++;
        }

    }

    private void Update()
    {
        
    }
}
