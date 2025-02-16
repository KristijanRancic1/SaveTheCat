using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic; // Needed for Lists

public class InventoryManager : MonoBehaviour
{
    public Image[] inventorySlots; // UI slots
    public Sprite emptySlotIcon; // Default empty slot icon

    private List<string> itemTags = new List<string>(); // Stores item tags (e.g., "FlashlightPickup")

    private void Start()
    {
        // Initialize slots as empty
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            inventorySlots[i].sprite = emptySlotIcon;
            itemTags.Add(""); // Empty tag for each slot
        }
    }

    // Add an item with an icon and a tag
    public bool AddItem(Sprite itemIcon, string itemTag)
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            if (inventorySlots[i].sprite == emptySlotIcon) // Find an empty slot
            {
                inventorySlots[i].sprite = itemIcon;
                itemTags[i] = itemTag; // Store tag
                Debug.Log("Picked up: " + itemTag);
                return true;
            }
        }
        Debug.Log("Inventory is full!");
        return false;
    }

    // Remove an item
    public void RemoveItem(int slotIndex)
    {
        if (slotIndex >= 0 && slotIndex < inventorySlots.Length)
        {
            inventorySlots[slotIndex].sprite = emptySlotIcon; // Reset slot
            itemTags[slotIndex] = ""; // Remove tag
            Debug.Log("Dropped item from slot " + slotIndex);
        }
    }

    // Check if the inventory contains an item by tag
    public bool HasItem(string tag)
    {
        return itemTags.Contains(tag);
    }
}
