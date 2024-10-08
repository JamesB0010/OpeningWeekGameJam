using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private Transform playerTransform;

    private Rigidbody rb;

    [SerializeField]
    private float movementSpeed;
    private void Start()
    {
        this.rb = GetComponent<Rigidbody>();
    }

    public void setPlayerTransform(Transform trans)
    {
        this.playerTransform = trans;
    }


    private void Update()
    {
        //move towards player

        Vector3 directionToPlayer = this.playerTransform.position - this.transform.position;

        directionToPlayer.Normalize();

        Vector3 Velocity = directionToPlayer * this.movementSpeed;

        float prevYVel = this.rb.velocity.y;

        Velocity.y = prevYVel;

        this.rb.velocity = Velocity;

    }
}
