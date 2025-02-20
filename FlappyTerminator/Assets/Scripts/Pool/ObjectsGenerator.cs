using System.Collections;
using UnityEngine;

public abstract class ObjectsGenerator : MonoBehaviour
{
    [SerializeField] protected float Delay;    
    [SerializeField] protected ObjectPool Pool;

    protected IEnumerator Generate()
    {
        var wait = new WaitForSeconds(Delay);

        while (enabled)
        {
            yield return wait;
            Spawn();
        }
    }

    protected abstract void Spawn();
}
