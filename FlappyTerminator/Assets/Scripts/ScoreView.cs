using TMPro;
using UnityEngine;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private TMP_Text _countText;
    [SerializeField] private ScoreCounter _scoreCounter;

    private void OnEnable()
    {
        _scoreCounter.CountChanged += ShowCount;
    }

    private void OnDisable()
    {
        _scoreCounter.CountChanged -= ShowCount;
    }

    private void ShowCount(int count)
    {
        _countText.text = count.ToString();
    }
}
