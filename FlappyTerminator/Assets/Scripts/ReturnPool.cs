using System;
using UnityEngine;

public class ReturnPool : MonoBehaviour
{
    public event Action<ReturnPool> LeftFieldView;

    public void Back()
    {
        LeftFieldView?.Invoke(this);
    }
}
