using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    [SerializeField] private float _growingSpeed;

    private void Update()
    {
        transform.localScale += (Vector3.one * _growingSpeed * Time.deltaTime) ;
    }
}
    