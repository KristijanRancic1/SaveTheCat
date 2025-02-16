using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadStartScreen : MonoBehaviour
{
    // Public method to load the start screen
    public void LoadStartScene()
    {
        // Load the scene named "StartScreen"
        SceneManager.LoadScene("LevelSelector");
    }
}