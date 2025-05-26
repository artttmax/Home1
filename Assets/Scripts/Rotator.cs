using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _yRotationSpeed;

    private void Update()
    {
        transform.rotation *= Quaternion.Euler(0, _yRotationSpeed * Time.deltaTime, 0);
    }
}
