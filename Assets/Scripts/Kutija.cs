using UnityEngine;

public class Kutija : MonoBehaviour
{
    public KutijaKod[] digits;  // Reference to the two digits
    public string correctCode = "27";  // Set your correct 2-digit code
    public CameraMovement cameraMovement;  // Reference to the CameraMovement script
    public FocusObject nextFocus = FocusObject.Objekt3; // The next object to focus on

    void OnMouseDown()
    {
        CheckCode();
    }

    void CheckCode()
    {
        string enteredCode = "";
        foreach (KutijaKod digit in digits)
        {
            enteredCode += digit.GetDigit();
        }

        Debug.Log("Entered Code: " + enteredCode);

        if (enteredCode == correctCode)
        {
            Debug.Log("Correct Code! Box opens.");
            
            // Remove the box (disable or destroy)
            gameObject.SetActive(false); 
            
            // Move the camera focus
            if (cameraMovement != null)
            {
                cameraMovement.currentFocus = nextFocus;
            }
        }
        else
        {
            Debug.Log("Wrong Code! Try again.");
        }
    }
}
