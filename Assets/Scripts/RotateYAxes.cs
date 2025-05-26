using UnityEngine;

public class RotateYAxes : MonoBehaviour
{
    [SerializeField] private float _yRotationSpeed;

    private void Update()
    {
        transform.Rotate(0, _yRotationSpeed, 0);
    }
}
