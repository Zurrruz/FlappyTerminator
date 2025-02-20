using System;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private EnemyGenerator _enemyGenerator;

    private int _count = 0;

    public event Action<int> CountChanged;

    private void OnEnable()
    {
        _enemyGenerator.Created += FollowEventEnemyDestroyed;
    }

    private void OnDisable()
    {
        _enemyGenerator.Created -= FollowEventEnemyDestroyed;
    }

    private void FollowEventEnemyDestroyed(EnemyCopter enemyCopter)
    {
        enemyCopter.EnemyDestroyed += IncreaseCount;
    }

    private void IncreaseCount(int victoryPoint, EnemyCopter enemyCopter)
    {
        _count += victoryPoint;

        enemyCopter.EnemyDestroyed -= IncreaseCount;

        CountChanged?.Invoke(_count);
    }

    public void Restart()
    {
        _count = 0;
    }
}
