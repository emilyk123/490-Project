using UnityEngine;
using UnityEngine.UIElements;

public class UI : MonoBehaviour
{
    [SerializeField] UIDocument uiDoc;

    void Start()
    {
        VisualElement root = uiDoc.rootVisualElement;
        root.style.display = DisplayStyle.None;
    }
}
