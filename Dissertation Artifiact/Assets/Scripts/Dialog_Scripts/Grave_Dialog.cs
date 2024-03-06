using UnityEngine;
using TMPro;

public class Grave_Dialog : MonoBehaviour
{
    public GameObject textBox; // Reference to the text box GameObject
    public TMP_Text TMP;
    private bool isInRange = false;
    private bool isTextBoxActive = false;

    private void Start()
    {
        textBox.SetActive(false);
        TMP.gameObject.SetActive(false);
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
        TMP.gameObject.SetActive(isTextBoxActive);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Assuming the character has a "Player" tag
        {
            isInRange = true; // Set the flag to true when the character enters the trigger zone
        }

        // Update the text if provided by the triggering object
        DialogueTrigger dialogueTrigger = other.GetComponent<DialogueTrigger>();
        if (dialogueTrigger != null)
        {
            string newText = dialogueTrigger.dialogueText;
            Debug.Log("Dialogue Text: " + newText);
            UpdateText(newText);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isInRange = false; // Set the flag to false when the character exits the trigger zone
        }
    }

    // Function to update the text
    public void UpdateText(string newText)
    {
        if (TMP != null)
        {
            TMP.text = newText;
        }
    }
}