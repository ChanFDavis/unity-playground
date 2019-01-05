using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed; // Movement speed
    public float jumpHeight;

    //private Rigidbody rb; // This object's rigid body
    private CharacterController controller;
    private Vector3 velocity;

    private void Start()
    {
        // GetComponent<type>() gets the specified component from the object using this script.
        //rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
        velocity = Vector3.zero;
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

//        float jump = jumpHeight * Input.GetAxis("Jump");

        Vector3 move = new Vector3(moveHorizontal, 0.0f, moveVertical) * speed;

        // Time.deltaTime is the time passed since the last frame.
        velocity.y += Physics.gravity.y * Time.deltaTime;

        if (controller.isGrounded && velocity.y < 0)
        {
            velocity.y = 0;
        }

        //TODO: Put these two move calls into one.
        controller.Move(velocity * Time.deltaTime);
        controller.Move(move * Time.deltaTime * speed);

        if(move != Vector3.zero)
        {
            transform.forward = move;
        }


    }

}
