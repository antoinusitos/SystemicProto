using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WaterChangeState : MonoBehaviour
{
    private Color _baseColor;
    public Material toColor;

    private Material _baseMaterial;

    public Renderer renderer = null;

    public float speed = 0.2f;
    private float _currentState = 0;

    private Rigidbody _rigidBody = null;

    public float stateChanged = 0.5f;

    public UnityEvent eventsWater = null;
    public UnityEvent eventsCold = null;

    private void Start()
    {
        _baseMaterial = renderer.material;
        _baseColor = _baseMaterial.color;
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _baseMaterial.color = Color.Lerp(_baseColor, toColor.color, _currentState);
        if(_currentState >= stateChanged)
        {
            eventsCold.Invoke();
        }
        else
        {
            eventsWater.Invoke();
        }
    }

	public void GoToChange ()
    {
        _currentState += speed * Time.deltaTime;
        if (_currentState > 1) _currentState = 1;
    }

    public void GoToBase()
    {
        _currentState -= speed * Time.deltaTime;
        if (_currentState < 0) _currentState = 0;
    }
}
