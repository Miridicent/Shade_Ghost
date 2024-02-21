using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    
    public GameObject dialogBox;
    public Text dialogText;

    public void ShowDialog(string text)
    {
        text = "Hello";
        dialogText.text = text;
        dialogBox.SetActive(true);
    }

    public void HideDialog()
    {
        dialogBox.SetActive(false);
    }
}
