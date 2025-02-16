using TMPro;
using UnityEngine;

public class KutijaKod : MonoBehaviour
{
    private int currentNumber = 0;
    private TextMeshPro textMesh;

    void Start()
    {
        textMesh = GetComponent<TextMeshPro>();
        UpdateDisplay();
    }

    void OnMouseDown()
    {
        IncrementNumber(); // Click to change number
    }

    void IncrementNumber()
    {
        currentNumber = (currentNumber + 1) % 10; // Loops from 0 to 9
        UpdateDisplay();
    }

    void UpdateDisplay()
    {
        textMesh.text = currentNumber.ToString();
    }

    public int GetDigit()
    {
        return currentNumber;
    }
}
