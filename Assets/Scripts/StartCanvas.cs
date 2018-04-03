using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCanvas : MonoBehaviour
{
    public GameObject canvas = null;

	void Start ()
    {
        canvas.SetActive(true);
    }

}
