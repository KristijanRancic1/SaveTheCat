using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public string itemName; // Set this in the Inspector

    void OnMouseDown()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player"); // Find Player
        if (player != null)
        {
            InventoryManager inventory = player.GetComponent<InventoryManager>();
            if (inventory != null)
            {
                bool added = inventory.AddItem(itemName);
                if (added)
                {
                    Destroy(gameObject); // Remove item from scene if added
                }
            }
        }
    }
}
