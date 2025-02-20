using UnityEngine;

public class BulletsGenerator : ObjectsGenerator
{
    [SerializeField] private Transform _pointCreation;

    private void OnEnable()
    {
        StartCoroutine(Generate());
    }

    protected override void Spawn(ObjectPool objectPool)
    {
        var bullet = objectPool.GetObject();

        bullet.transform.SetPositionAndRotation(_pointCreation.position, _pointCreation.rotation);
    }
}
