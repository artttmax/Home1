using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moovingSpeed;

    private void Update()
    {
        transform.Translate(Vector3.forward * _moovingSpeed * Time.deltaTime);
    }
}
