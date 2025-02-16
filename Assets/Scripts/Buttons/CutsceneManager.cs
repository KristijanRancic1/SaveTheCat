using UnityEngine;
using UnityEngine.UI;

public class CutsceneManager : MonoBehaviour
{
    public Sprite[] cutsceneImages; // Array to hold the 8 images
    public Image displayImage; // Reference to the UI Image component
    public Button nextButton; // Reference to the Next button
    public Button previousButton; // Reference to the Previous button

    private int currentIndex = 0; // Track the current image index

    void Start()
    {
        // Set the initial image
        UpdateImage();

        // Add listeners to the buttons
        nextButton.onClick.AddListener(NextImage);
        previousButton.onClick.AddListener(PreviousImage);

        // Disable the Previous button at the start
        previousButton.interactable = false;
    }

    void NextImage()
    {
        if (currentIndex < cutsceneImages.Length - 1)
        {
            currentIndex++;
            UpdateImage();

            // Enable the Previous button if not on the first image
            previousButton.interactable = true;

            // Disable the Next button if on the last image
            if (currentIndex == cutsceneImages.Length - 1)
            {
                nextButton.interactable = false;
            }
        }
    }

    void PreviousImage()
    {
        if (currentIndex > 0)
        {
            currentIndex--;
            UpdateImage();

            // Enable the Next button if not on the last image
            nextButton.interactable = true;

            // Disable the Previous button if on the first image
            if (currentIndex == 0)
            {
                previousButton.interactable = false;
            }
        }
    }

    void UpdateImage()
    {
        // Update the displayed image
        displayImage.sprite = cutsceneImages[currentIndex];
    }
}