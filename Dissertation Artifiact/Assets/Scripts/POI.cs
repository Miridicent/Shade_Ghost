using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POI : MonoBehaviour
{
    new public GameObject gameObject;
    public AudioClip clip;
    public AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        clip = GetComponent<AudioClip>();   
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        gameObject.SetActive(true); 
        source.Play();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        gameObject.SetActive(false);
    }
}
