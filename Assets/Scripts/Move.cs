using UnityEngine;
using System;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5f;
    public SpriteRenderer spriteRenderer;
    public Transform prizemljePosition;
    public Transform prviKatPosition;
    public Transform drugiKatPosition;

    private bool isOnStairs = false;
    private string currentFloorTag = "prizemlje";
    private Transform nextFloorPosition;
    private Transform previousFloorPosition;

    private void Update()
    {
        transform.rotation = Quaternion.identity;

        float moveDirection = Input.GetAxis("Horizontal");

        if (isOnStairs)
        {
            SetTeleportPositions();

            if (Input.GetKeyDown(KeyCode.W) && nextFloorPosition != null)
            {
                transform.position = nextFloorPosition.position;
                return;
            }
            else if (Input.GetKeyDown(KeyCode.S) && previousFloorPosition != null)
            {
                transform.position = previousFloorPosition.position;
                return;
            }
        }

        transform.position += new Vector3(moveDirection * moveSpeed * Time.deltaTime, 0f, 0f);

        if (moveDirection > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (moveDirection < 0)
        {
            spriteRenderer.flipX = true;
        }
        gameObject.GetComponent<Animator>().SetFloat("Walking", Math.Abs(moveDirection));
    }

    private void SetTeleportPositions()
    {
        switch (currentFloorTag)
        {
            case "prizemlje":
                nextFloorPosition = prviKatPosition;
                previousFloorPosition = null;
                break;
            case "prviKat":
                nextFloorPosition = drugiKatPosition;
                previousFloorPosition = prizemljePosition;
                break;
            case "drugiKat":
                nextFloorPosition = null;
                previousFloorPosition = prviKatPosition;
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Stairs"))
        {
            isOnStairs = true;
        }

        if (collision.CompareTag("prizemlje"))
        {
            currentFloorTag = "prizemlje";
        }
        else if (collision.CompareTag("prviKat"))
        {
            currentFloorTag = "prviKat";
        }
        else if (collision.CompareTag("drugiKat"))
        {
            currentFloorTag = "drugiKat";
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Stairs"))
        {
            isOnStairs = false;
        }
    }
}
