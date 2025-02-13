using System.Collections;
using UnityEngine;

public abstract class ObjectsGenerator : MonoBehaviour
{
    [SerializeField] protected float _delay;    
    [SerializeField] protected ObjectPool _pool;

    protected IEnumerator Generate()
    {
        var wait = new WaitForSeconds(_delay);

        while (enabled)
        {
            yield return wait;
            Spawn();
        }
    }

    protected abstract void Spawn();
}
