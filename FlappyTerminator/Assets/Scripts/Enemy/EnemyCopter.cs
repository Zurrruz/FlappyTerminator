using System;
using UnityEngine;

public class EnemyCopter : PoolingReturner
{
    [SerializeField] private int _victoryPoint;

    public event Action<int, EnemyCopter> EnemyDestroyed;

    public void Ñrush()
    {
        EnemyDestroyed?.Invoke(_victoryPoint, this);
        Back();
    }
}
