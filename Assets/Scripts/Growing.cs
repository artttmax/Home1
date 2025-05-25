using UnityEngine;

public class Growing : MonoBehaviour
{
    [SerializeField] private float _growingSpeed;
    void Update()
    {
        transform.localScale += new Vector3 (_growingSpeed, _growingSpeed, _growingSpeed) ;
    }
}
    