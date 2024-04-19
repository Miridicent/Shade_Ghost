 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock : MonoBehaviour
{
    public string targetTag = "";
    public GameObject targetGameObject;
    public int unCount = 0;
    private bool isInRange;

    public AudioSource audioSource;
    public AudioClip clip;

    private void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();

        // Set the AudioClip for the AudioSource
        audioSource.clip = clip;
    }

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
            audioSource.Play();
            unCount++;
        }
    }
    
}
