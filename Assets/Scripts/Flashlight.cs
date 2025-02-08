using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    public Camera mainCamera; // Assign the main camera in the Inspector
    public Transform player;  // Assign the player's Transform in the Inspector

    void Update()
    {
        // Get mouse position in world space
        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(mainCamera.transform.position.z - player.position.z)));

        // Calculate direction from flashlight to mouse
        Vector3 direction = (mousePosition - transform.position).normalized;

        // Calculate angle and rotate the flashlight
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
