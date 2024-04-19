using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class Final_Gate : MonoBehaviour
{
    Pendent_holder holder;
   
    public GameObject Gate;
    bool IsinRange;
    public AudioClip clip;
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        clip = GetComponent<AudioClip>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Gate"))
        {
            IsinRange = true;
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Gate"))
        {
            
            IsinRange = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Pendent_holder.Pendent > 3 && IsinRange)
        {
            Gate.SetActive(false);
            source.Play();
            Pendent_holder.Pendent++;
        }
    }
}
