using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BecomeSmaller : MonoBehaviour
{
    public Transform transformToModify = null;

    public float speed = 0.2f;

    public void Execute()
    {
        transformToModify.localScale -= Vector3.one * speed * Time.deltaTime;
        if(transformToModify.localScale.x <= 0.1f)
        {
            Destroy(gameObject);
        }
    }
}
