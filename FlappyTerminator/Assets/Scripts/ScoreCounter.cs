using System;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private static int Count = 0;

    public static event Action<int> CountChanged;

    public static void IncreaseCount()
    {
        Count++;
        CountChanged?.Invoke(Count);
    }

    public static void Restart()
    {
        Count = 0;
    }
}
