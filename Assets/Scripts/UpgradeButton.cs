using UnityEngine;

public class UpgradeButton : MonoBehaviour
{
    public GameObject upgrade;

    void Awake()
    {
        upgrade.SetActive(false);
    }

    void OnMouseDown()
    {
        if (upgrade != null)
        {
            upgrade.SetActive(!upgrade.activeSelf);
        }
    }
}