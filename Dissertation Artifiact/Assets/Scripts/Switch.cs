using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public Sprite sprite1; // First sprite
    public Sprite sprite2; // Second sprite
    private SpriteRenderer spriteRenderer; // Reference to SpriteRenderer component

    private void Start()
    {
        // Get the SpriteRenderer component attached to the GameObject
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Set the initial sprite
        if (sprite1 != null)
        {
            spriteRenderer.sprite = sprite1;
        }
    }

    private void OnMouseDown()
    {
        // Change the sprite when the GameObject is clicked
        if (spriteRenderer.sprite == sprite1) // If current sprite is the off tile
        {
            spriteRenderer.sprite = sprite2; // Change to on
        }
        else // If current sprite is the on tile
        {
            spriteRenderer.sprite = sprite1; // Change to off
        }
    }
}
