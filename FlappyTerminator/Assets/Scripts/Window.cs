using UnityEngine;
using UnityEngine.UI;

public abstract class Window : MonoBehaviour
{
    [SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private Button _actionButton;

    protected CanvasGroup CanvasGroup => _canvasGroup;
    protected Button ActionButton => _actionButton;

    private void OnEnable()
    {
        _actionButton.onClick.AddListener(OnButtonClick);
    }

    private void OnDisable()
    {
        _actionButton.onClick.RemoveListener(OnButtonClick);
    }

    protected abstract void OnButtonClick();

    public void Close()
    {
        CanvasGroup.alpha = 0f;
        ActionButton.interactable = false;
    }

    public void Open()
    {
        CanvasGroup.alpha = 1f;
        ActionButton.interactable = true;
    }
}
