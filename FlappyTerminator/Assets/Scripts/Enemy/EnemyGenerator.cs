using System;
using UnityEngine;

public class EnemyGenerator : ObjectsGenerator
{
    [SerializeField] private float _lowerBound;
    [SerializeField] private float _upperBound;

    public event Action<EnemyCopter> Created;

    private void Start()
    {
        StartCoroutine(Generate());
    }

    protected override void Spawn()
    {
        float spawnPositionY = UnityEngine.Random.Range(_upperBound, _lowerBound);
        Vector3 spawnPoint = new(transform.position.x, spawnPositionY, transform.position.z);

        var enemy = Pool.GetObject();
        
        Created?.Invoke((EnemyCopter)enemy);

        enemy.transform.position = spawnPoint;
    }      
}
