using UnityEngine;

public class CopterTracker : MonoBehaviour
{
    [SerializeField] private Copter _copter;
    [SerializeField] private float _xOffset;
        
    private void Update()
    {
        var position = transform.position;
        position.x = _copter.transform.position.x + _xOffset;
        transform.position = position; 
    }
}
