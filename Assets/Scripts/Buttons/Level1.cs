using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldButtonHandler : MonoBehaviour
{
    private void OnMouseDown()
    {
        // This method is called when the object is clicked
        Debug.Log("World Button Clicked! Loading Level1...");

        // Load the Level1 scene
        SceneManager.LoadScene("Level1");
    }
}