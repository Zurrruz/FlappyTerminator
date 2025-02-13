using TMPro;
using UnityEngine;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private TMP_Text _countText;

    private void OnEnable()
    {
        ScoreCounter.CountChanged += ShowCount;
    }

    private void OnDisable()
    {
        ScoreCounter.CountChanged -= ShowCount;
    }

    private void ShowCount(int count)
    {
        _countText.text = count.ToString();
    }
}
