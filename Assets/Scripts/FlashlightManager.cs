using UnityEngine;

public class FlashlightManager : MonoBehaviour
{
    private InventoryManager inventory;
    private GameObject flashlight;
    private bool hasFlashlight = false;

    private void Start()
    {
        // Find Player's Inventory
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            inventory = player.GetComponent<InventoryManager>();
        }

        // Find the flashlight object after the game starts
        flashlight = GameObject.FindGameObjectWithTag("Flashlight");

        // Ensure flashlight is turned off at the start
        if (flashlight != null)
        {
            flashlight.SetActive(false); // Ensure flashlight starts off
            Debug.Log("Flashlight initialized and turned off.");
        }
        else
        {
            Debug.LogError("Flashlight object not found! Please assign the flashlight in the scene.");
        }
    }

    private void Update()
    {
        // Check if inventory contains the FlashlightPickup item
        if (!hasFlashlight && inventory != null && inventory.HasItem("FlashlightPickup"))
        {
            if (flashlight != null)
            {
                hasFlashlight = true;
                flashlight.SetActive(true); // Turn on flashlight when picked up
                Debug.Log("Flashlight picked up and activated!");
            }
            else
            {
                Debug.LogError("Flashlight object is missing!");
            }
        }

        // If the player has the flashlight, allow toggling with F
        if (hasFlashlight && flashlight != null)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                flashlight.SetActive(!flashlight.activeSelf); // Toggle flashlight
                Debug.Log("Flashlight toggled: " + flashlight.activeSelf);
            }
        }
    }
}
