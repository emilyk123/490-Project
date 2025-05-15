using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject UI;
    public PlayerMovement player;

    void OnMouseDown()
    {
        if (UI != null)
        {
            UI.SetActive(!UI.activeSelf);
            player.canMove = true;
        }
    }
}