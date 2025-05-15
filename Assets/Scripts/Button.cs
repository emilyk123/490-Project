using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject UI;

    void OnMouseDown()
    {
        if (UI != null)
        {
            UI.SetActive(!UI.activeSelf);  // Toggle active state
            Debug.Log("UI Active? " + UI.activeSelf);
        }
        else
        {
            Debug.LogWarning("UI reference is null!");
        }
    }
}