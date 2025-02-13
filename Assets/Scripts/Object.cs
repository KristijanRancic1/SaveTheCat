using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    public CameraMovement cameraMovement;  // Reference to the CameraMovement script
    private bool isFocusing = false;      // To track if the camera is focusing on an object

    public float scaleMultiplier = 1.5f;  // How much to scale the object when focused
    public float normalScale = 1f;        // Normal scale of the object

    private Vector3 originalScale;        // To store the object's original scale

    void Start()
    {
        // Store the original scale of the object when the game starts
        originalScale = transform.localScale;
    }

    // Called when the object is clicked (must have a collider)
    void OnMouseDown()
    {
        if (cameraMovement != null)
        {
            // Check if the camera is currently focusing on something
            if (isFocusing)
            {
                // If already focusing, stop following the player and reset the focus
                cameraMovement.StopFollowing();
                isFocusing = false;  // Set focusing to false

                // Reset the scale of the object when focus is removed
                ResetObjectScale();
            }
            else
            {
                // Check the tag of the object clicked and set focus accordingly
                if (gameObject.CompareTag("Ploca"))
                {
                    cameraMovement.FocusOnPloca();  // Focus on the Ploca
                    isFocusing = true;  // Set focusing to true
                    ScaleObject(scaleMultiplier);  // Scale up the object when it is focused
                }
                else if (gameObject.CompareTag("Kutija1"))
                {
                    cameraMovement.FocusOnKutija1();  // Focus on the Kutija1
                    isFocusing = true;
                    ScaleObject(scaleMultiplier);
                }
                else if (gameObject.CompareTag("Objekt3"))
                {
                    cameraMovement.FocusOnObjekt3();  // Focus on Objekt3
                    isFocusing = true;
                    ScaleObject(scaleMultiplier);
                }
                else if (gameObject.CompareTag("Objekt4"))
                {
                    cameraMovement.FocusOnObjekt4();  // Focus on Objekt4
                    isFocusing = true;
                    ScaleObject(scaleMultiplier);
                }
                else if (gameObject.CompareTag("Objekt5"))
                {
                    cameraMovement.FocusOnObjekt5();  // Focus on Objekt5
                    isFocusing = true;
                    ScaleObject(scaleMultiplier);
                }
                else if (gameObject.CompareTag("Objekt6"))
                {
                    cameraMovement.FocusOnObjekt6();  // Focus on Objekt6
                    isFocusing = true;
                    ScaleObject(scaleMultiplier);
                }
                else if (gameObject.CompareTag("Objekt7"))
                {
                    cameraMovement.FocusOnObjekt7();  // Focus on Objekt7
                    isFocusing = true;
                    ScaleObject(scaleMultiplier);
                }
                else if (gameObject.CompareTag("Objekt8"))
                {
                    cameraMovement.FocusOnObjekt8();  // Focus on Objekt8
                    isFocusing = true;
                    ScaleObject(scaleMultiplier);
                }
                else if (gameObject.CompareTag("Objekt9"))
                {
                    cameraMovement.FocusOnObjekt9();  // Focus on Objekt9
                    isFocusing = true;
                    ScaleObject(scaleMultiplier);
                }
                else if (gameObject.CompareTag("Objekt10"))
                {
                    cameraMovement.FocusOnObjekt10();  // Focus on Objekt10
                    isFocusing = true;
                    ScaleObject(scaleMultiplier);
                }
                else if (gameObject.CompareTag("Objekt11"))
                {
                    cameraMovement.FocusOnObjekt11();  // Focus on Objekt11
                    isFocusing = true;
                    ScaleObject(scaleMultiplier);
                }
                else if (gameObject.CompareTag("Objekt12"))
                {
                    cameraMovement.FocusOnObjekt12();  // Focus on Objekt12
                    isFocusing = true;
                    ScaleObject(scaleMultiplier);
                }
                else if (gameObject.CompareTag("Objekt13"))
                {
                    cameraMovement.FocusOnObjekt13();  // Focus on Objekt13
                    isFocusing = true;
                    ScaleObject(scaleMultiplier);
                }
                else if (gameObject.CompareTag("Objekt14"))
                {
                    cameraMovement.FocusOnObjekt14();  // Focus on Objekt14
                    isFocusing = true;
                    ScaleObject(scaleMultiplier);
                }
                else if (gameObject.CompareTag("Objekt15"))
                {
                    cameraMovement.FocusOnObjekt15();  // Focus on Objekt15
                    isFocusing = true;
                    ScaleObject(scaleMultiplier);
                }
                else if (gameObject.CompareTag("Objekt16"))
                {
                    cameraMovement.FocusOnObjekt16();  // Focus on Objekt16
                    isFocusing = true;
                    ScaleObject(scaleMultiplier);
                }
                else if (gameObject.CompareTag("Objekt17"))
                {
                    cameraMovement.FocusOnObjekt17();  // Focus on Objekt17
                    isFocusing = true;
                    ScaleObject(scaleMultiplier);
                }
                else
                {
                    cameraMovement.StopFollowing();  // If clicked on something else, stop following
                    isFocusing = false;  // Set focusing to false
                }
            }
        }
    }

    // Method to scale the object when focused
    private void ScaleObject(float multiplier)
    {
        transform.localScale = originalScale * multiplier;
    }

    // Method to reset the scale of the object when focus is lost
    private void ResetObjectScale()
    {
        transform.localScale = originalScale;
    }
}
