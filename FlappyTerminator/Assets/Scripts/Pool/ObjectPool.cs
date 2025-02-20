using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private PoolingReturner _prefab;

    private Queue<PoolingReturner> _pool;

    private void Awake()
    {
        _pool = new Queue<PoolingReturner>();
    }

    private void PutObject(PoolingReturner obj)
    {
        _pool.Enqueue(obj);
        obj.gameObject.SetActive(false);
        obj.Finished -= PutObject;
    }

    public void Reset()
    {
        _pool.Clear();
    }

    public PoolingReturner GetObject()
    {
        if (_pool.Count == 0)
        {
            var obj = Instantiate(_prefab);
            obj.Finished += PutObject;

            return obj;
        }

        _pool.Peek().Finished += PutObject;
        _pool.Peek().gameObject.SetActive(true);

        return _pool.Dequeue();
    }
}