using UnityEngine;

public class BulletsGenerator : ObjectsGenerator
{
    [SerializeField] private Transform _pointCreation;

    private void OnEnable()
    {
        StartCoroutine(Generate());
    }

    protected override void Spawn()
    {
        var bullet = Pool.GetObject();

        bullet.transform.position = _pointCreation.position;
        bullet.transform.rotation = _pointCreation.rotation;
    }
}
