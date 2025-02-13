using System;
using UnityEngine;

[RequireComponent(typeof(ScoreCounter))]
[RequireComponent(typeof(CopterCollisionHandler))]
public class Copter : MonoBehaviour
{
    private ScoreCounter _scoreCounter;
    private CopterCollisionHandler _collisionHandlers;

    public event Action GameOver;

    private void Awake()
    {
        _scoreCounter = GetComponent<ScoreCounter>();
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
