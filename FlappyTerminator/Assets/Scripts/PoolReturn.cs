using System;
using UnityEngine;

public class PoolReturn : MonoBehaviour
{
    public event Action<PoolReturn> Finished;
    public event Action<int, PoolReturn> EnemyDestroyed;

    public void Back()
    {
        Finished?.Invoke(this);
    }

    public void Back(int VictoryPoint)
    {
        EnemyDestroyed?.Invoke(VictoryPoint, this);

        Finished?.Invoke(this);
    }
}
