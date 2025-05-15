using UnityEngine;
using UnityEngine.UIElements;

public class UI : MonoBehaviour
{
    [SerializeField] UIDocument uiDoc;

    private Button _healthBuyButton;
    private Button _keyBuyButton;
    private Button _upgradeBuyButton;
    private Button _cancelButton;
    VisualElement displayUI;

    private void Start()
    {
        displayUI = uiDoc.rootVisualElement;

        displayUI.RegisterCallback<PointerDownEvent>(evt => Debug.Log("PointerDown at UI root"));

        _healthBuyButton = uiDoc.rootVisualElement.Q("healthBuy") as Button;
        _keyBuyButton = uiDoc.rootVisualElement.Q("keyBuy") as Button;
        _upgradeBuyButton = uiDoc.rootVisualElement.Q("upgradeBuy") as Button;
        _cancelButton = uiDoc.rootVisualElement.Q("cancel") as Button;

        _healthBuyButton?.RegisterCallback<ClickEvent>(OnHealthBuyClicked);
        _keyBuyButton?.RegisterCallback<ClickEvent>(OnKeyBuyClicked);
        _upgradeBuyButton?.RegisterCallback<ClickEvent>(OnUpgradeBuyClicked);
        _cancelButton?.RegisterCallback<ClickEvent>(OnCancelClicked);
        
        displayUI.style.display = DisplayStyle.None;
    }

    private void OnDisable()
    {
        _healthBuyButton?.UnregisterCallback<ClickEvent>(OnHealthBuyClicked);
        _keyBuyButton?.UnregisterCallback<ClickEvent>(OnKeyBuyClicked);
        _upgradeBuyButton?.UnregisterCallback<ClickEvent>(OnUpgradeBuyClicked);
        _cancelButton?.UnregisterCallback<ClickEvent>(OnCancelClicked);
    }

    private void OnHealthBuyClicked(ClickEvent evt) {
        Debug.Log("Buy Health");
    }
    private void OnKeyBuyClicked(ClickEvent evt) {
        Debug.Log("Buy Key");
    }
    private void OnUpgradeBuyClicked(ClickEvent evt) {
        Debug.Log("Buy Upgrade");
    }
    private void OnCancelClicked(ClickEvent evt) {
        displayUI.style.display = DisplayStyle.None;
    }
}