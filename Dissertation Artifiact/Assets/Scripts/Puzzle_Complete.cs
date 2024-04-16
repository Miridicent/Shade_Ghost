using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puzzle_Complete : MonoBehaviour
{
    bool complete;
    public GameObject Key1;
    public GameObject Key2;
    public GameObject Key3;

    public GameObject Win;

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Key1.activeSelf && !Key2.activeSelf && !Key3.activeSelf)
        {
            complete = true;
        }

        else
        {
            complete = false;
        }

        if (complete)
        {
            Win.SetActive(true);
            
            
        }

        if (complete && Input.GetKeyUp(KeyCode.Return))
        {
            SceneManager.LoadScene("Grave_Hub");
        }
    }
}
