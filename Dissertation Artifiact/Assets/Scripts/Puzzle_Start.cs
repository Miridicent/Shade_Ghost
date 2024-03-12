using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Puzzle_Start : MonoBehaviour
{

    public string sceneManager;
    private bool isInRange = false;
    public string targetTag = "Player";
    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D collider)
    {

        if (collider.CompareTag("Player")) // Assuming the character has a "Player" tag
        {
            isInRange = true; // Set the flag to true when the character enters the trigger zone
        }


    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isInRange = false; // Set the flag to false when the character exits the trigger zone
        }
    }

    

// Update is called once per frame
void Update()
    {
        if (isInRange && Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Player entered the gate trigger");
            SceneManager.LoadScene(sceneManager);
        }

    }
}
