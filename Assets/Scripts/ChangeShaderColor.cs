using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShaderColor : MonoBehaviour
{
    public float speed = 0.5f;

    private bool _direction = false; // true = go up
    private bool _isChanging = false;

    private Material _mat = null;

    public string _shaderOption = "";

    private float _baseValue = 0;

    private void Start()
    {
        _mat = GetComponent<Renderer>().material;
        if(_mat != null)
        {
            _baseValue = _mat.GetFloat(_shaderOption);
        }
    }

    public void SetShaderOption(string shaderOption)
    {
        _shaderOption = shaderOption;
    }

    public void FadeUp(float newValue)
    {
        if (_mat == null) return;

        if (_isChanging && _direction)
            return;

        _isChanging = true;
        _direction = true;
        StopCoroutine("Fade");
        StartCoroutine(Fade(newValue, _shaderOption));
    }

    public void FadeDown(float newValue)
    {
        if (_mat == null) return;

        if (_isChanging && !_direction)
            return;

        _isChanging = true;
        _direction = false;
        StopCoroutine("Fade");
        StartCoroutine(Fade(newValue, _shaderOption));
    }

    private IEnumerator Fade(float newValue, string shaderOption)
    {
        float timer = _mat.GetFloat(shaderOption);

        float endValue = newValue;
        if (newValue == -100)
            endValue = _baseValue;

        if(_direction)
        {
            while (timer < endValue)
            {
                _mat.SetFloat(shaderOption, timer);
                
                timer += Time.deltaTime * speed;

                yield return null;
            }
        }
        else
        {
            while (timer > endValue)
            {
                _mat.SetFloat(shaderOption, timer);
                
                timer -= Time.deltaTime * speed;

                yield return null;
            }
        }
        _mat.SetFloat(shaderOption, endValue);
        _isChanging = false;
    }
}
