using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    public AudioSource audioSource; // Assign an AudioSource in the Inspector

    // Make this method public
    public void PlaySound()
    {
        if (audioSource != null)
        {
            // Ensure the AudioSource is not already playing
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
            else
            {
                // If it's already playing, stop and replay it
                audioSource.Stop();
                audioSource.Play();
            }
        }
        else
        {
            Debug.LogWarning("AudioSource is not assigned in ButtonSound.");
        }
    }
}