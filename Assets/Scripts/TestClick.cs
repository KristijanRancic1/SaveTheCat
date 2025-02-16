using UnityEngine;

public class TestClick : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log("Click detected on: " + gameObject.name);
    }
}
