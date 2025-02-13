using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private ReturnPool _prefab;
    [SerializeField] private Queue<ReturnPool> _pool;
    
    public IEnumerable<ReturnPool> PooledObjects => _pool;

    private void Awake()
    {
        _pool = new Queue<ReturnPool>();
    }

    public ReturnPool GetObject()
    {
        if (_pool.Count == 0)
        {
            var obj = Instantiate(_prefab);            
            obj.LeftFieldView += PutObject;

            return obj;
        }
        else
        {
            _pool.Peek().LeftFieldView += PutObject;
            _pool.Peek().gameObject.SetActive(true);

            return _pool.Dequeue();
        }
    }

    private void PutObject(ReturnPool obj)
    {        
        _pool.Enqueue(obj);
        obj.gameObject.SetActive(false);
        obj.LeftFieldView -= PutObject;
    }

    public void Reset()
    {
        _pool.Clear();
    }
}