using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform cameraDirection = null;

    public float speed = 1.0f;

	void Update ()
    {
        float vertical = Input.GetAxis("Vertical");
        if (vertical != 0)
        {
            Vector3 fw = cameraDirection.forward;
            fw.y = 0;
            transform.position += vertical * fw * speed * Time.deltaTime;
        }

        float horizontal = Input.GetAxis("Horizontal");
        if (horizontal != 0)
        {
            Vector3 fw = cameraDirection.right;
            fw.y = 0;
            transform.position += horizontal * fw * speed * Time.deltaTime;
        }
    }
}
