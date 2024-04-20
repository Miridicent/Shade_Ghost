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
    // compares if it's the right key
        if (other.CompareTag(targetTag))
        {
            // if the key overlaps the lock collider then isInRange becomes true 
            Debug.Log("Trigger entered by object with tag: " + targetTag);
            isInRange = true;
        }
        //else
        //{
        //    Debug.Log("Wrong Key");
        //}

    }

    // If is in range is true and the mouse is let go then the lock is unlocked and the key becomes inactive
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
