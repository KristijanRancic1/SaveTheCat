using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    // Reference to the button's Text component (optional, to change button text)
    public Text buttonText;

    // Reference to the GameObject to toggle on/off when paused
    public GameObject pauseOverlay;

    // Boolean to track whether the game is paused
    private bool isPaused = false;

    // Method to be called when the button is clicked
    public void OnPauseButtonClick()
    {
        // Toggle pause state
        isPaused = !isPaused;

        // Pause or unpause the game
        if (isPaused)
        {
            Pause();
        }
        else
        {
            Unpause();
        }

        // Optional: Update button text to reflect the current state
        if (buttonText != null)
        {
            buttonText.text = isPaused ? "Resume" : "Pause";
        }

        // Toggle the pause overlay GameObject
        if (pauseOverlay != null)
        {
            pauseOverlay.SetActive(isPaused);
        }
    }

    // Method to pause the game
    private void Pause()
    {
        Time.timeScale = 0; // Set time scale to 0 to pause the game
    }

    // Method to unpause the game
    private void Unpause()
    {
        Time.timeScale = 1; // Set time scale back to 1 to resume the game
    }
}