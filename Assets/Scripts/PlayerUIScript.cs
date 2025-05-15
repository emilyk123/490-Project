using UnityEngine;
using UnityEngine.UIElements;

public class PlayerUIScript : MonoBehaviour
{
    [SerializeField] private UIDocument uiDocument;
    private ProgressBar expBar;
    private ProgressBar healthBar;
    public GameObject upgrade;

    void Awake()
    {
        // Get the root VisualElement from the UI Document
        var root = uiDocument.rootVisualElement;

        // Find the ProgressBar with the name "EXP"
        expBar = root.Q<ProgressBar>("EXP");
        healthBar = root.Q<ProgressBar>("health");
    }

    public void IncreaseExp(float amount)
    {
        if (expBar == null)
            return;

        expBar.value = Mathf.Clamp(expBar.value + amount, expBar.lowValue, expBar.highValue);
        if (expBar.value == 100)
        {
            upgrade.SetActive(true);
            expBar.value = 0;
        }
    }
    public void changeHealth(float amount)
    {
        if (healthBar == null)
            return;

        healthBar.value = Mathf.Clamp(healthBar.value + amount, expBar.lowValue, expBar.highValue);
    }
}
