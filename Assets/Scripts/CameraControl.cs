using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform cameraToControl = null;

    private void Update()
    {
        float vertical = Input.GetAxis("Mouse Y");
        if (vertical != 0)
        {
            cameraToControl.Rotate(Vector3.right, -vertical);
        }

        float horizontal = Input.GetAxis("Mouse X");
        if (horizontal != 0)
        {
            transform.Rotate(Vector3.up, horizontal);
        }
    }
}
