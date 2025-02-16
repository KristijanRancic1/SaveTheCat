using UnityEngine;
using UnityEngine.UI;

public class ToggleObjectsAndColor : MonoBehaviour
{
    // Array of objects to toggle
    public GameObject[] objectsToToggle;

    // Reference to the Image component whose color will be toggled
    public Image colorImage;

    // Colors for the image
    private Color onColor = Color.yellow;
    private Color offColor = Color.white;

    // Initialize everything to the "off" state when the game starts
    private void Start()
    {
        // Turn off all objects in the array
        foreach (GameObject obj in objectsToToggle)
        {
            obj.SetActive(false);
        }

        // Set the image color to white (off state)
        colorImage.color = offColor;
    }

    // Method to be called when the button is clicked
    public void OnButtonClick()
    {
        // Check if all objects are active
        bool allActive = AreAllObjectsActive();

        // Toggle the active state of all objects
        foreach (GameObject obj in objectsToToggle)
        {
            obj.SetActive(!allActive);
        }

        // Toggle the color of the image
        colorImage.color = allActive ? offColor : onColor;
    }

    // Helper method to check if all objects in the array are active
    private bool AreAllObjectsActive()
    {
        foreach (GameObject obj in objectsToToggle)
        {
            if (!obj.activeSelf)
            {
                return false;
            }
        }
        return true;
    }
}