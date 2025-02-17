using System;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private EnemyGenerator _enemyGenerator;

    private int _count = 0;

    public static event Action<int> CountChanged;

    private void OnEnable()
    {
        _enemyGenerator.Created += FollowEventEnemyDestroyed;
    }

    private void OnDisable()
    {
        _enemyGenerator.Created -= FollowEventEnemyDestroyed;
    }

    private void FollowEventEnemyDestroyed(PoolReturn poolReturn)
    {
        poolReturn.EnemyDestroyed += IncreaseCount;
    }

    private void IncreaseCount(int victoryPoint, PoolReturn poolReturn)
    {
        _count += victoryPoint;

        poolReturn.EnemyDestroyed -= IncreaseCount;

        CountChanged?.Invoke(_count);
    }

    public void Restart()
    {
        _count = 0;
    }
}
