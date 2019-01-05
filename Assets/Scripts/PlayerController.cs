using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))] // Adds a Rigidbody if object doesn't have one already.
public class PlayerController : MonoBehaviour {

    public float speed; // Movement speed
    public float jumpHeight;

    private bool isGrounded; // Is the player touching the ground?
    private Rigidbody rb; // This object's rigid body

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() // Called before physics calculation
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        float jump = jumpHeight * Input.GetAxis("Jump");

        Debug.Log(Input.GetAxis("Jump"));

        rb.position += new Vector3(moveHorizontal, 0, moveVertical);

        Vector3 movement = new Vector3(moveHorizontal, jump, moveVertical);

        rb.AddForce(movement * speed);
    } 

}
