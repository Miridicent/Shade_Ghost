using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Camera mainCamera;
    public float distanceFromCamera = 1f; // Adjust this to control the distance from the camera
    public Vector3 offset = new Vector3(0, 1, 0); // Adjust this to control the offset from the camera

    private RectTransform dialogBoxRect;

    void Start()
    {
        dialogBoxRect = GetComponent<RectTransform>();
        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }
    }

    void LateUpdate()
    {
        // Make sure the main camera is assigned
        if (mainCamera == null)
            return;

        // Calculate the position of the dialog box relative to the camera
        Vector3 dialogBoxPosition = mainCamera.transform.position + mainCamera.transform.forward * distanceFromCamera + offset;

        // Convert world position to screen position
        Vector2 screenPosition = mainCamera.WorldToScreenPoint(dialogBoxPosition);

        // Set the position of the dialog box
        dialogBoxRect.position = screenPosition;
    }
}