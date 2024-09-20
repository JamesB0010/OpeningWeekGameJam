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
    }

    private void ApplyTranslation(float forwardInput, float leftInput)
    {
        Vector3 direction = this.camera.transform.forward;

        Vector3 velocity = new Vector3(forwardInput, forwardInput, forwardInput);

        velocity *= this.movementSpeed;


        float velY = this.rb.velocity.y;

        velocity.Scale(direction);

        velocity.y = velY;

        this.rb.velocity = velocity;




       

        

    }
}
