using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _yRotationSpeed;

    private void Update()
    {
        transform.Rotate(0, _yRotationSpeed, 0);
    }
}
