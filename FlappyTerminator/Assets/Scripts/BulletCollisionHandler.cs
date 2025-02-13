using System;
using UnityEngine;

public class BulletCollisionHandler : MonoBehaviour
{
    [SerializeField] private ReturnPool _returnPool;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out EnemyCopter enemy))
        {
            enemy.Ñrush();
            _returnPool.Back();
        }
    }
}
