 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock : MonoBehaviour
{
    public string targetTag = "";
    public GameObject targetGameObject;
    public int unCount = 0;
    private bool isInRange;
    

   
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag(targetTag))
        {
            // Perform actions when the specified object enters the trigger
            Debug.Log("Trigger entered by object with tag: " + targetTag);
            isInRange = true;
        }
        //else
        //{
        //    Debug.Log("Wrong Key");
        //}

    }

    private void Update()
    {
        if (isInRange && Input.GetMouseButtonUp(0))
        {
            targetGameObject.SetActive(false);
            unCount++;
        }
    }
    
}
