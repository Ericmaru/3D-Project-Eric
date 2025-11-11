using UnityEngine;

public class Sun : MonoBehaviour
{
    [SerializeField] private float _rotationVelocity = 10;
    private float hours = 0.1f;
    private int cyclepeed = 1;
    void Update()
    {
        hours++;
        transform.rotation = Quaternion.Euler(_rotationVelocity * Time.deltaTime, 0, 0);
    }
}
