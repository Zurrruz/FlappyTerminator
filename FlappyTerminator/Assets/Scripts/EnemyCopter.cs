using System;
using UnityEngine;

public class EnemyCopter : MonoBehaviour
{
    [SerializeField] private ReturnPool _returnPool;

    public void Ñrush()
    {
        _returnPool.Back();

        ScoreCounter.IncreaseCount();
    }
}
