using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private UIDocument uiDocument;

    void Start()
    {
        // Get the root visual element of the UI Toolkit document
        VisualElement root = uiDocument.rootVisualElement;

        // Use the fully-qualified type to avoid Button name collision
        UnityEngine.UIElements.Button newGameButton = root.Q<UnityEngine.UIElements.Button>("NewGame");

        // Add a click event handler
        if (newGameButton != null)
        {
            newGameButton.clicked += OnNewGameClicked;
        }
    }

    private void OnNewGameClicked()
    {
        SceneManager.LoadScene("Game");
    }
}