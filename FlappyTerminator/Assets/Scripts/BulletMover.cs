using System.Collections;
using UnityEngine;

public class BulletMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float _time = 0.01f;

    private Rigidbody2D _rigidbody2D;

    private WaitForSeconds _delay;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();

        _delay = new WaitForSeconds(_time);
    }

    private void OnEnable()
    {
        StartCoroutine(StartFly());
    }

    private IEnumerator StartFly()
    {
        yield return _delay;
        _rigidbody2D.velocity = transform.right * _speed;
    }
}
