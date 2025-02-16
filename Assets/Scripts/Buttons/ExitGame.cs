using UnityEngine;

public class ExitGame : MonoBehaviour
{
    // Mark the function as public
    public void QuitGame()
    {
        // Quit the application
        Application.Quit();

        // (Optional) Log a message to confirm the game is quitting
        Debug.Log("Game is exiting...");
    }
}