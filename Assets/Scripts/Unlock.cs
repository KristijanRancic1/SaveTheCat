using UnityEngine;

public class Unlock : MonoBehaviour
{
    public GameObject lock1;  // Change to GameObject type if you're working with tags
    public GameObject lock2;  // Change to GameObject type if you're working with tags

    public GameObject kavez;
    public GameObject Congrats;
    private bool isLock1Unlocked = false;
    private bool isLock2Unlocked = false;
    private Animator animator;

    void Start()
    {
        if (lock1 == null)
        {
            Debug.LogError("Lock1 reference missing!");
        }
        if (lock2 == null)
        {
            Debug.LogError("Lock2 reference missing!");
        }
        if (kavez == null)
        {
            Debug.LogError("Kavez reference missing!");
        }
        animator = GetComponent<Animator>();
        if (animator == null)
        {
            Debug.LogError("Animator component missing!");
        }
    }

    private void Update()
    {
        // Check if the locks are inactive
        if (lock1 != null && lock2 != null)
        {
            isLock1Unlocked = !lock1.activeSelf;  // True if lock1 is inactive
            isLock2Unlocked = !lock2.activeSelf;  // True if lock2 is inactive

            if (isLock1Unlocked && isLock2Unlocked)
            {
                Destroykavez();
                animator.SetTrigger("Happy");
                Congrats.SetActive(true);
            }
        }
    }

    private void Destroykavez()
    {
        if (kavez != null)
        {
            Debug.Log("Both locks are unlocked! Destroying 'kavez'...");
            Destroy(kavez);  // Destroy the cage object
        }
        else
        {
            Debug.LogWarning("No object with 'kavez' tag assigned to destroy.");
        }
    }
}
