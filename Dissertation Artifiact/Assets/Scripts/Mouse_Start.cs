using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Start : MonoBehaviour
{
    public Vector2 startingPosition = new Vector2(-9, 3); 

    void Start()
    {
        // Set the starting position of the mouse cursor
        SetMousePosition(startingPosition.x, startingPosition.y);
    }

    void Update()
    {
        // Lock and hide the cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void SetMousePosition(float x, float y)
    {
        // Set the mouse position using ScreenPointToRay
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(x, y, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            transform.position = hit.point;
        }
    }
}
