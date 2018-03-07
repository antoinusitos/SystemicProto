using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1.0f;

    public Vector3 direction = Vector3.zero;

    private Transform _transform = null;

    private void Start()
    {
        _transform = transform;
    }

	void Update ()
    {
        _transform.position += direction * speed * Time.deltaTime;
    }
}
