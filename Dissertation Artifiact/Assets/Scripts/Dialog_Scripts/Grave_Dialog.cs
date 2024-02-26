using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Grave_Dialog : MonoBehaviour
{
    public GameObject textBox; // Reference to the text box GameObject
    public TMP_Text TMP;
    private bool isInRange = false;
    private bool isTextBoxActive = false;


    private void Start()
    {
        textBox.SetActive(false);
    }
    void Update()
    {
        if (isInRange && Input.GetKeyDown(KeyCode.Return)) // Check if Enter key is pressed
        {
            ToggleTextBox(); // Toggle the text box visibility
        }
    }

    private void ToggleTextBox()
    {
        isTextBoxActive = !isTextBoxActive; // Toggle the text box state
        textBox.SetActive(isTextBoxActive); // Set the text box active state
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Assuming the character has a "Player" tag
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


    // The text to display
    public string textToShow = "Default Text";

    // Function to update the text
    public void UpdateText()
    {
        if (TMP != null)
        {
            TMP.text = textToShow;
        }
    }

    // This will be called when the script is loaded or the value of the textToShow is changed in the Inspector
    private void OnValidate()
    {
        UpdateText();
    }

    // This will be called when the GameObject this script is attached to is enabled
    private void OnEnable()
    {
        UpdateText();
    }
}