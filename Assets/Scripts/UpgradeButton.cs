using UnityEngine;

public class UpgradeButton : MonoBehaviour
{
    public GameObject upgrade;
    public PlayerUIScript player;

    void Awake()
    {
        upgrade.SetActive(false);
    }

    void OnMouseDown()
    {
        if (upgrade != null)
        {
            upgrade.SetActive(!upgrade.activeSelf);
            player.changeHealth(10);
        }
    }
}