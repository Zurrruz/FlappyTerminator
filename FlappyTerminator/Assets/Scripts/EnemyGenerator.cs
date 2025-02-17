using System;
using UnityEngine;

public class EnemyGenerator : ObjectsGenerator
{
    [SerializeField] private float _lowerBound;
    [SerializeField] private float _upperBound;

    public event Action<PoolReturn> Created;

    private void Start()
    {
        StartCoroutine(Generate());
    }

    protected override void Spawn()
    {
        float spawnPositionY = UnityEngine.Random.Range(_upperBound, _lowerBound);
        Vector3 spawnPoint = new(transform.position.x, spawnPositionY, transform.position.z);

        var enemy = _pool.GetObject();
        
        Created?.Invoke(enemy);

        enemy.transform.position = spawnPoint;
    }      
}
