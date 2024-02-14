using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puzzle_Start : MonoBehaviour
{
    public string targetTag = "Player";
    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.CompareTag(targetTag) && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Player entered the gate trigger");
            SceneManager.LoadScene("Gate_Puzzle");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
