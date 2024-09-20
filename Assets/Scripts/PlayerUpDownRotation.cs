using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUpDownRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float upDownInput = Input.GetAxis("Mouse Y");

        transform.rotation = transform.rotation * Quaternion.Euler(-upDownInput,0,0);
    }
}
