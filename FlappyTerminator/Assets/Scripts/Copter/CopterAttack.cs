using System.Collections;
using UnityEngine;

public class CopterAttack : MonoBehaviour
{
    [SerializeField] private ObjectPool _pool;
    [SerializeField] private Transform _containerBullet;
    [SerializeField] private InputService _inputService;
    [SerializeField] private float _delay;

    private bool _canShoot = true;

    private WaitForSeconds _time;

    private void Awake()
    {
        _time = new WaitForSeconds(_delay);
    }

    private void OnEnable()
    {
        _inputService.Attacked += Shoot;
    }

    private void OnDisable()
    {
        _inputService.Attacked -= Shoot;
    }

    private void Shoot()
    {
        if(_canShoot)
        {
            var bullet = _pool.GetObject();

            bullet.transform.position = _containerBullet.position;
            bullet.transform.rotation = _containerBullet.rotation;

            _canShoot = false;

            StartCoroutine(Recharge());
        }
    }

    private IEnumerator Recharge()
    {
        yield return _time;
        _canShoot = true;
    }
}
