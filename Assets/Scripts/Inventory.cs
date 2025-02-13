using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<string> inventory = new List<string>(); // Store item names
    public int inventorySize = 5; // Limit to 5 items

    // Add an item to inventory
    public bool AddItem(string itemName)
    {
        if (inventory.Count < inventorySize)
        {
            inventory.Add(itemName);
            Debug.Log("Picked up: " + itemName);
            return true; // Successfully added
        }
        else
        {
            Debug.Log("Inventory is full!");
            return false; // Inventory full
        }
    }

    // Remove an item from inventory
    public void RemoveItem(string itemName)
    {
        if (inventory.Contains(itemName))
        {
            inventory.Remove(itemName);
            Debug.Log("Dropped: " + itemName);
        }
    }

    // Check if the inventory has an item
    public bool HasItem(string itemName)
    {
        return inventory.Contains(itemName);
    }
}
