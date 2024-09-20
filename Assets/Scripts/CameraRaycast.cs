using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRaycast : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Test");
            Physics.Raycast(transform.position, transform.forward, out RaycastHit hit);
            if (hit.rigidbody)
            {
                Debug.Log("12");
            }
        }
    }
}
