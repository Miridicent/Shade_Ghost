using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POI : MonoBehaviour
{
    //Gets the Poi game object and the shine audio clip
    new public GameObject gameObject;
    public AudioClip clip;
    public AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        clip = GetComponent<AudioClip>();   
    }

    // when the player is in range of something they can inspect then the mark appears and players the audio clip
    private void OnTriggerEnter2D(Collider2D other)
    {
        gameObject.SetActive(true); 
        source.Play();
    }

    // when no longer in range the mark will become inactive
    private void OnTriggerExit2D(Collider2D other)
    {
        gameObject.SetActive(false);
    }
}
