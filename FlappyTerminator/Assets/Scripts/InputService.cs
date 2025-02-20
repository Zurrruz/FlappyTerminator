using System;
using UnityEngine;

public class InputService : MonoBehaviour
{
    private KeyCode _keyCodeJump = KeyCode.Space;
    private KeyCode _keyCodeAttack = KeyCode.W;

    public event Action Attacked;
    public event Action Jumped;

    private void Update()
    {
        InspectAttack();
        InspectJump();
    }

    private void InspectAttack()
    {
        if (Input.GetKeyDown(_keyCodeAttack)) 
            Attacked?.Invoke();
    }

    private void InspectJump()
    {
        if(Input.GetKeyDown(_keyCodeJump)) 
            Jumped?.Invoke();  
    }
}
