using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public int maxLife = 1;
    private int _currentLife = 1;

    public void Start()
    {
        _currentLife = maxLife;
    }
}
