using UnityEngine;
using UnityEngine.UI; // For UI elements

public class InventoryManager : MonoBehaviour
{
    public Image[] inventorySlots; // Array for item slots (UI Images)
    public Sprite emptySlotIcon; // Default empty slot icon

    private void Start()
    {
        // Initialize slots as empty
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            inventorySlots[i].sprite = emptySlotIcon;
        }
    }

    // Add an item to inventory
    public bool AddItem(Sprite itemIcon)
    {
        Debug.Log("Checking inventory space...");
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            if (inventorySlots[i].sprite == emptySlotIcon) // Find an empty slot
            {
                inventorySlots[i].sprite = itemIcon;
                Debug.Log($"Picked up item in slot {i}!");
                return true;
            }
        }
        Debug.Log("Inventory is full!");
        return false;
    }

    // Remove an item from inventory
    public void RemoveItem(int slotIndex)
    {
        if (slotIndex >= 0 && slotIndex < inventorySlots.Length)
        {
            inventorySlots[slotIndex].sprite = emptySlotIcon; // Reset slot to empty
            Debug.Log($"Dropped item from slot {slotIndex}");
        }
        else
        {
            Debug.LogError("Invalid slot index!");
        }
    }
}
