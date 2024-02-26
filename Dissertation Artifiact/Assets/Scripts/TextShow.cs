using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextShow : MonoBehaviour
{
    // Reference to the TMP_Text component
    public TMP_Text textField;

    // The text to display
    public string textToShow = "Default Text";

    // Function to update the text
    public void UpdateText()
    {
        if (textField != null)
        {
            textField.text = textToShow;
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
