using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryLevel1 : MonoBehaviour
{
    // Public method to be called by the button's OnClick event
    public void OnButtonClick()
    {
        // This method is called when the button is clicked
        Debug.Log("World Button Clicked! Loading Level1...");

        // Load the Level1 scene
        SceneManager.LoadScene("Level1");
    }
}