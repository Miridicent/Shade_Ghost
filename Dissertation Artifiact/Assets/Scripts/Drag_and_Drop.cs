using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag_and_Drop : MonoBehaviour
{

    //Vector3 mousePosition;
    // Start is called before the first frame update

    // the game object clicked on will equal selectedObject 
    public GameObject selectedObject;
    Vector3 offset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Gets mouse position
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // if the left mouse button is down and the mouse overlaps with a trigger, drag the game object 
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);
            if (targetObject)
            {
                selectedObject = targetObject.transform.gameObject;
                offset = selectedObject.transform.position - mousePosition;
            }
        }
        // drops object 
        if (Input.GetMouseButtonUp(0) && selectedObject)
        {
            selectedObject = null;
        }
        // places object where the mouse lets go of it
        if (selectedObject)
        {
            selectedObject.transform.position = mousePosition + offset;
        }
    }
}
