using UnityEngine;

public class EnemyCopter : MonoBehaviour
{
    [SerializeField] private PoolReturn _poolReturn;
    [SerializeField] private int _victoryPoint;

    public void �rush()
    {
        _poolReturn.Back(_victoryPoint);
    }
}
