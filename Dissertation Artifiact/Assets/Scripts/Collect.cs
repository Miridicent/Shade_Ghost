using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{

// Creates the variables 
    bool IsinRange;
    public int unlock = 0;
    GameObject collidedObject;
    public GameObject Gate;
    Pendent_holder pendent_holder;
    public AudioClip clip;
    public AudioSource source;

    // When colliding with an onject the object being collided with is assinged to the collision game object 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Key_Frag") || collision.CompareTag("Gate"))
        {
            IsinRange = true;
            collidedObject = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Key_Frag"))
        {
            IsinRange = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        clip = GetComponent<AudioClip>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if in range and player presses the "Enter" key
        if (IsinRange && collidedObject.gameObject.CompareTag("Key_Frag") && Input.GetKeyDown(KeyCode.Return))
        {
        // Unlock is incremented by 1
            unlock++;
            // Deactivate the collected fragment
            collidedObject.gameObject.SetActive(false);
            source.Play();
        }

        // when all keys are collected and the gate is in range then the gate will open
        if (unlock == 3 && collidedObject.gameObject.CompareTag("Gate") && IsinRange)
        {
            Gate.SetActive(false);
            Pendent_holder.Pendent++;
        }
    }
}
