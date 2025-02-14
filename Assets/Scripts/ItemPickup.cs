using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Sprite itemIcon; // Assign in Inspector

    void OnMouseDown()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            InventoryManager inventory = player.GetComponent<InventoryManager>();
            if (inventory != null)
            {
                Debug.Log("Trying to add item to inventory...");
                bool added = inventory.AddItem(itemIcon);
                if (added)
                {
                    Debug.Log("Item added successfully. Destroying object.");
                    Destroy(gameObject); // Remove item from scene
                }
                else
                {
                    Debug.Log("Inventory is full! Can't pick up item.");
                }
            }
            else
            {
                Debug.LogError("InventoryManager not found on Player!");
            }
        }
        else
        {
            Debug.LogError("Player object not found!");
        }
    }
}
