using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField]
    float movementSpeed;

    [SerializeField]
    float rotationSpeed;

    [SerializeField]
    Camera camera;


    private void Start()
    {
        this.rb = GetComponent<Rigidbody>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void Update()
    {
        this.ApplyTranslation(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));

        float mouseX = Input.GetAxis("Mouse X");

        Vector3 YRotation = new Vector3(0, mouseX, 0);

        this.rb.MoveRotation(this.rb.rotation * Quaternion.EulerAngles(YRotation * Time.deltaTime * this.rotationSpeed));


        Debug.DrawRay(this.camera.transform.position, this.camera.transform.forward, Color.red);

        Debug.Log(mouseX);
    }

    private void ApplyTranslation(float forwardInput, float leftInput)
    {
        float yVelocity = this.rb.velocity.y;

        Vector3 rigidBodyDirection = new Vector3(leftInput, yVelocity, forwardInput).normalized;

        Vector3.Scale(rigidBodyDirection, this.camera.transform.forward);

        this.rb.velocity = new Vector3(leftInput * this.movementSpeed, yVelocity, forwardInput * this.movementSpeed);




        bool hi = true == true ? true : false;
    }
}
