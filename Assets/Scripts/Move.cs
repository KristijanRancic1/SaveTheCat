using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5f;
    public SpriteRenderer spriteRenderer;

    private void Update()
    {
        // Ensure the player stays upright
        transform.rotation = Quaternion.identity;
        
        // Handle movement
        float moveDirection = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveDirection, 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

        // Flip sprite based on movement direction
        if (moveDirection > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (moveDirection < 0)
        {
            spriteRenderer.flipX = true;
        }
    }
}
