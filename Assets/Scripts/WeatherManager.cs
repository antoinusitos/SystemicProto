using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherManager : MonoBehaviour
{
    public float randomMin = 20.0f;
    public float randomMax = 30.0f;

    private float _currentRandom = 0;
    private float _currentProgression = 0;

    public StringObject[] allWeatherPossible = null;

    public bool startWithWeather = false;
    public string startingWeather = "";

    private GameObject _currentWeather = null;

    private Transform _transform = null;

    private void Start()
    {
        _transform = transform;

        if (startWithWeather)
        {
            ChangeToWeather(startingWeather);
        }
    }

    public void ChangeToWeather(string name)
    {
        for(int i = 0; i < allWeatherPossible.Length; i++)
        {
            if(allWeatherPossible[i].name == name)
            {
                _currentRandom = Random.Range(randomMin, randomMax);
                Destroy(_currentWeather);
                _currentWeather = Instantiate(allWeatherPossible[i].theObject, _transform.position, Quaternion.identity);
            }
        }
    }

    private void Update()
    {
        _currentProgression += Time.deltaTime;
        if(_currentProgression >= _currentRandom)
        {
            _currentProgression = 0;
            int randWeather = Random.Range(0, allWeatherPossible.Length);
            ChangeToWeather(allWeatherPossible[randWeather].name);
        }
    }
}
