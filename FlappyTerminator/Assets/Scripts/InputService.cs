using UnityEngine;

public class InputService : MonoBehaviour
{
    private KeyCode _keyCodeUp = KeyCode.Space;
    private KeyCode _keyCodeAttack = KeyCode.W;

    public bool Up => Input.GetKeyDown(_keyCodeUp);
    public bool IsAttacking => Input.GetKeyDown(_keyCodeAttack);
}
