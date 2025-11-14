using UnityEngine;

public class Billboard : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        // Cache a reference to the main camera for efficiency
        mainCamera = Camera.main;

        // Important: Ensure your main camera in the scene has the "MainCamera" tag.
        // Otherwise, Camera.main will return null and cause errors.
    }

    void LateUpdate()
    {
        // LateUpdate is used to ensure the camera has finished its movement
        // before the billboard adjusts its rotation.
        if (mainCamera != null)
        {
            // Make the object look at the camera's position
            transform.LookAt(mainCamera.transform.position);

            // Rotate an additional 180 degrees if the sprite is facing away
            // This is often necessary for sprites that are initially oriented
            // to face the opposite direction of their "forward" vector.
            transform.Rotate(0, 180, 0);
        }
    }
}