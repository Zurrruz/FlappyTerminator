using System;
using UnityEngine;

public class CopterCollisionHandler : MonoBehaviour
{
    public event Action CollisionDetected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Menace _))
        {
            CollisionDetected?.Invoke();
        }
    }
}
