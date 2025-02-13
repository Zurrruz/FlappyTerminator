using UnityEngine;

public class EnemyGenerator : ObjectsGenerator
{
    [SerializeField] private float _lowerBound;
    [SerializeField] private float _upperBound;

    private void Start()
    {
        StartCoroutine(Generate());
    }

    protected override void Spawn()
    {
        float spawnPositionY = Random.Range(_upperBound, _lowerBound);
        Vector3 spawnPoint = new(transform.position.x, spawnPositionY, transform.position.z);

        var enemy = _pool.GetObject();
        enemy.transform.position = spawnPoint;
    }
}
