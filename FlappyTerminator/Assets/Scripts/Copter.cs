using System;
using UnityEngine;

[RequireComponent(typeof(CopterCollisionHandler))]
public class Copter : MonoBehaviour
{
    private CopterCollisionHandler _collisionHandlers;

    public event Action GameOver;

    private void Awake()
    {
        _collisionHandlers = GetComponent<CopterCollisionHandler>();
    }

    private void OnEnable()
    {
        _collisionHandlers.CollisionDetected += ProcessCollision;
    }

    private void OnDisable()
    {
        _collisionHandlers.CollisionDetected -= ProcessCollision;
    }

    private void ProcessCollision()
    {
        GameOver?.Invoke();
    }
}
