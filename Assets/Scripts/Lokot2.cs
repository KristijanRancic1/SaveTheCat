using UnityEngine;
using System.Collections;

public class Lock2 : MonoBehaviour
{
    private bool hasKey2 = false;
    private InventoryManager inventory;
    private Animator animator;

    private void Start()
    {
        // Find Player's Inventory
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            inventory = player.GetComponent<InventoryManager>();
        }

        // Get Animator Component
        animator = GetComponent<Animator>();
        if (animator == null)
        {
            Debug.LogError("Animator component missing on Lock2!");
        }

        // Check if Collider2D exists (important for clicks)
        Collider2D col = GetComponent<Collider2D>();
        if (col == null)
        {
            Debug.LogError("No Collider2D found on Lock2! Click detection won't work.");
        }
    }

    private void Update()
    {
        // Check if the player has the key in their inventory
        if (!hasKey2 && inventory != null && inventory.HasItem("kljuc2"))
        {
            hasKey2 = true;
            Debug.Log("Key detected in inventory!");
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("Lock clicked!");

        if (hasKey2 && animator != null)
        {
            Debug.Log("Key found in inventory! Triggering unlock...");

            // Trigger animation
            animator.SetTrigger("Unlock");

            // Start coroutine to remove key and deactivate lock
            StartCoroutine(DeactivateAfterAnimation());
        }
        else if (!hasKey2)
        {
            Debug.Log("Player does NOT have the required key!");
        }
    }

    private IEnumerator DeactivateAfterAnimation()
    {
        Debug.Log("Waiting for unlock animation to finish...");
        
        // Wait for animation to finish
        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);

        // Find the index of the key item in the inventory
        int keyIndex = FindItemIndex("kljuc2");

        if (keyIndex != -1)
        {
            inventory.RemoveItem(keyIndex); // Remove key from inventory
            Debug.Log("Key removed from inventory!");
        }
        else
        {
            Debug.LogWarning("Key not found in inventory!");
        }

        // Deactivate the Lock2 GameObject
        gameObject.SetActive(false);
        Debug.Log("Lock2 deactivated!");
    }

    private int FindItemIndex(string itemTag)
    {
        // Loop through inventory slots and find the correct item
        for (int i = 0; i < inventory.inventorySlots.Length; i++)
        {
            if (inventory.HasItem(itemTag)) // Check stored tags
            {
                return i;
            }
        }
        return -1; // Item not found
    }
}
