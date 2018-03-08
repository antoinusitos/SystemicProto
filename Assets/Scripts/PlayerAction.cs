using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public Transform pointToAttach = null;
    public Transform cameraFromAction = null;

	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if(Physics.Raycast(cameraFromAction.position, cameraFromAction.forward, out hit, 10.0f))
            {
                if(hit.collider.GetComponent<CarryObject>())
                {
                    hit.transform.SetParent(pointToAttach);
                    hit.transform.localPosition = Vector3.zero;
                    hit.transform.localRotation = Quaternion.identity;
                    hit.transform.localRotation = Quaternion.Euler(0, 90, 0);
                    hit.transform.GetComponent<Rigidbody>().isKinematic = true;
                }
            }
        }
	}
}
