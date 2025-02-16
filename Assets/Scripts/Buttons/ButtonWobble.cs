using UnityEngine;
using UnityEngine.UI;

public class ButtonWobble : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Get the Animator component
        animator = GetComponent<Animator>();

        // Add a click listener to the button
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(TriggerWobble);
        }
    }

    void TriggerWobble()
    {
        // Trigger the wobble animation
        animator.SetTrigger("wobble");
    }
}