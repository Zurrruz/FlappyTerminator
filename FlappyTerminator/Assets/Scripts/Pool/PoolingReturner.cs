using System;
using UnityEngine;

public class PoolingReturner : MonoBehaviour
{
    public event Action<PoolingReturner> Finished;

    public void Back()
    {
        Finished?.Invoke(this);
    }    
}
