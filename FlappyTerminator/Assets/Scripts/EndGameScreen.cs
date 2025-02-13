using System;
using UnityEngine;

public class EndGameScreen : Window
{
    public event Action RestartButtonClicked;

    public override void Close()
    {
        CanvasGroup.alpha = 0f;
        ActionButton.interactable = false;
    }

    public override void Open()
    {
        CanvasGroup.alpha = 1f;
        ActionButton.interactable = true;
    }

    protected override void OnButtonClick()
    {
        RestartButtonClicked?.Invoke();
    }
}
