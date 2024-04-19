using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{

    bool IsinRange;
    public int unlock = 0;
    GameObject collidedObject;
    public GameObject Gate;
    Pendent_holder pendent_holder;
    public AudioClip clip;
    public AudioSource source;

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
        // Check if in range and player presses the "Return" key
        if (IsinRange && collidedObject.gameObject.CompareTag("Key_Frag") && Input.GetKeyDown(KeyCode.Return))
        {
            unlock++;
            // Deactivate the collected fragment
            collidedObject.gameObject.SetActive(false);
            source.Play();
        }

        if (unlock == 3 && collidedObject.gameObject.CompareTag("Gate") && IsinRange)
        {
            Gate.SetActive(false);
            Pendent_holder.Pendent++;
        }
    }
}
