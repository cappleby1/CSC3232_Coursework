using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody rb;
    public Vector3 movement;
 
 
    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Used to move the player
        Rigidbody rb = GetComponent < Rigidbody >();
        Vector3 velocity = rb.velocity ;

        if(Input.GetKey(KeyCode.A))
        {
            velocity.x =- speed ;
        }
        if(Input.GetKey(KeyCode.D))
        {
            velocity.x = speed;
        }
        if(Input.GetKey(KeyCode.W))
        {
            velocity.z = speed;
        }
        if(Input.GetKey(KeyCode.S))
        {
            velocity.z =- speed;
        }
        rb.velocity = velocity;    
    }
}
