using UnityEngine;

public class ObjectRemover : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PoolingReturner poolingReturner))
        {            
            poolingReturner.Back();
        }
    }
}
