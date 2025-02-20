using UnityEngine;

public class BulletCollisionHandler : MonoBehaviour
{
    [SerializeField] private PoolingReturner _poolReturn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out EnemyCopter enemy))
        {
            enemy.Ñrush();

            _poolReturn.Back();
        }
    }
}
