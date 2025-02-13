using UnityEngine;

public enum FocusObject
{
    None,      // Default value (no object is focused)
    Ploca,     // Focus on the Ploca
    Kutija1,   // Focus on Kutija1
    Objekt3,   // Focus on Objekt3
    Objekt4,   // Focus on Objekt4
    Objekt5,   // Focus on Objekt5
    Objekt6,   // Focus on Objekt6
    Objekt7,   // Focus on Objekt7
    Objekt8,   // Focus on Objekt8
    Objekt9,   // Focus on Objekt9
    Objekt10,  // Focus on Objekt10
    Objekt11,  // Focus on Objekt11
    Objekt12,  // Focus on Objekt12
    Objekt13,  // Focus on Objekt13
    Objekt14,  // Focus on Objekt14
    Objekt15,  // Focus on Objekt15
    Objekt16,  // Focus on Objekt16
    Objekt17   // Focus on Objekt17
}

public class CameraMovement : MonoBehaviour
{
    public Transform player;               // Reference to the player object
    public Vector3 offset;                 // The offset of the camera from the player
    public FocusObject currentFocus = FocusObject.None;  // Default is no object focused

    public Transform Ploca;                // Reference to the Ploca Transform
    public Transform Kutija1;              // Reference to the Kutija1 Transform
    public Transform Objekt3;              // Reference to the Objekt3 Transform
    public Transform Objekt4;              // Reference to the Objekt4 Transform
    public Transform Objekt5;              // Reference to the Objekt5 Transform
    public Transform Objekt6;              // Reference to the Objekt6 Transform
    public Transform Objekt7;              // Reference to the Objekt7 Transform
    public Transform Objekt8;              // Reference to the Objekt8 Transform
    public Transform Objekt9;              // Reference to the Objekt9 Transform
    public Transform Objekt10;             // Reference to the Objekt10 Transform
    public Transform Objekt11;             // Reference to the Objekt11 Transform
    public Transform Objekt12;             // Reference to the Objekt12 Transform
    public Transform Objekt13;             // Reference to the Objekt13 Transform
    public Transform Objekt14;             // Reference to the Objekt14 Transform
    public Transform Objekt15;             // Reference to the Objekt15 Transform
    public Transform Objekt16;             // Reference to the Objekt16 Transform
    public Transform Objekt17;             // Reference to the Objekt17 Transform

    public float focusSpeed = 5f;          // Speed at which the camera will transition
    public float zoomInDistance = 3f;      // Distance to zoom in for focused objects
    private bool isFocused = false;        // Track if the object is focused

    void Update()
    {
        // Switch statement to check what object is focused
        switch (currentFocus)
        {
            case FocusObject.None:
                // If no object is focused, camera follows the player
                transform.position = Vector3.Lerp(transform.position, player.position + offset, Time.deltaTime * focusSpeed);
                break;

            case FocusObject.Ploca:
                FocusOnObject(Ploca);
                break;

            case FocusObject.Kutija1:
                FocusOnObject(Kutija1);
                break;

            case FocusObject.Objekt3:
                FocusOnObject(Objekt3);
                break;

            case FocusObject.Objekt4:
                FocusOnObject(Objekt4);
                break;

            case FocusObject.Objekt5:
                FocusOnObject(Objekt5);
                break;

            case FocusObject.Objekt6:
                FocusOnObject(Objekt6);
                break;

            case FocusObject.Objekt7:
                FocusOnObject(Objekt7);
                break;

            case FocusObject.Objekt8:
                FocusOnObject(Objekt8);
                break;

            case FocusObject.Objekt9:
                FocusOnObject(Objekt9);
                break;

            case FocusObject.Objekt10:
                FocusOnObject(Objekt10);
                break;

            case FocusObject.Objekt11:
                FocusOnObject(Objekt11);
                break;

            case FocusObject.Objekt12:
                FocusOnObject(Objekt12);
                break;

            case FocusObject.Objekt13:
                FocusOnObject(Objekt13);
                break;

            case FocusObject.Objekt14:
                FocusOnObject(Objekt14);
                break;

            case FocusObject.Objekt15:
                FocusOnObject(Objekt15);
                break;

            case FocusObject.Objekt16:
                FocusOnObject(Objekt16);
                break;

            case FocusObject.Objekt17:
                FocusOnObject(Objekt17);
                break;

            default:
                break;
        }
    }

    // Method to focus on an object
    private void FocusOnObject(Transform targetObject)
    {
        // Move camera to focus on the target object
        transform.position = Vector3.Lerp(transform.position, targetObject.position - targetObject.forward * zoomInDistance, Time.deltaTime * focusSpeed);
        transform.LookAt(targetObject);  // Make the camera face the target object
    }

    // Method to stop following the player
    public void StopFollowing()
    {
        currentFocus = FocusObject.None;  // Set focus to None, which means stop following the player
        isFocused = false;  // Reset the focus state
    }

    // Methods to focus on individual objects
    public void FocusOnPloca() { currentFocus = FocusObject.Ploca; isFocused = true; }
    public void FocusOnKutija1() { currentFocus = FocusObject.Kutija1; isFocused = true; }
    public void FocusOnObjekt3() { currentFocus = FocusObject.Objekt3; isFocused = true; }
    public void FocusOnObjekt4() { currentFocus = FocusObject.Objekt4; isFocused = true; }
    public void FocusOnObjekt5() { currentFocus = FocusObject.Objekt5; isFocused = true; }
    public void FocusOnObjekt6() { currentFocus = FocusObject.Objekt6; isFocused = true; }
    public void FocusOnObjekt7() { currentFocus = FocusObject.Objekt7; isFocused = true; }
    public void FocusOnObjekt8() { currentFocus = FocusObject.Objekt8; isFocused = true; }
    public void FocusOnObjekt9() { currentFocus = FocusObject.Objekt9; isFocused = true; }
    public void FocusOnObjekt10() { currentFocus = FocusObject.Objekt10; isFocused = true; }
    public void FocusOnObjekt11() { currentFocus = FocusObject.Objekt11; isFocused = true; }
    public void FocusOnObjekt12() { currentFocus = FocusObject.Objekt12; isFocused = true; }
    public void FocusOnObjekt13() { currentFocus = FocusObject.Objekt13; isFocused = true; }
    public void FocusOnObjekt14() { currentFocus = FocusObject.Objekt14; isFocused = true; }
    public void FocusOnObjekt15() { currentFocus = FocusObject.Objekt15; isFocused = true; }
    public void FocusOnObjekt16() { currentFocus = FocusObject.Objekt16; isFocused = true; }
    public void FocusOnObjekt17() { currentFocus = FocusObject.Objekt17; isFocused = true; }
}
