using UnityEngine;

public class ToggleGameObjectOnClick : MonoBehaviour
{
    // Reference to the GameObject to toggle on/off
    public GameObject objectToToggle;

    // Method to be called when the button is clicked
    public void OnButtonClick()
    {
        // Check if the GameObject reference is assigned
        if (objectToToggle != null)
        {
            // Toggle the active state of the GameObject
            objectToToggle.SetActive(!objectToToggle.activeSelf);
        }
        else
        {
            Debug.LogWarning("No GameObject assigned to toggle.");
        }
    }
}