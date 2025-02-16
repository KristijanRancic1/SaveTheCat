using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Sprite itemIcon; // Assign in Inspector
    public string itemTag; // Set this in Inspector (e.g., "FlashlightPickup")

    void OnMouseDown()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            InventoryManager inventory = player.GetComponent<InventoryManager>();
            if (inventory != null)
            {
                Debug.Log("Trying to add item: " + itemTag);
                bool added = inventory.AddItem(itemIcon, itemTag);
                if (added)
                {
                    Debug.Log("Item added successfully.");
                    Destroy(gameObject); // Remove item from scene
                }
                else
                {
                    Debug.Log("Inventory is full!");
                }
            }
        }
    }
}
