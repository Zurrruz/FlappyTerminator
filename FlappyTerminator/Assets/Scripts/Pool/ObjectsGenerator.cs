using System.Collections;
using UnityEngine;

public abstract class ObjectsGenerator : MonoBehaviour
{
    [SerializeField] private float _delay;    
    [SerializeField] private ObjectPool _pool;

    protected IEnumerator Generate()
    {
        var wait = new WaitForSeconds(_delay);

        while (enabled)
        {
            yield return wait;
            Spawn(_pool);
        }
    }

    protected abstract void Spawn(ObjectPool objectPool);
}
