using UnityEngine;

public class Fou : MonoBehaviour
{
    [SerializeField] float _yRotateSpeed;
    [SerializeField] float _growSpeed;
    [SerializeField] float _moveSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.localScale += new Vector3(_growSpeed, _growSpeed, _growSpeed);
        transform.Rotate(0, _yRotateSpeed, 0);
        transform.Translate(Vector3.forward * _moveSpeed);
    }
}
