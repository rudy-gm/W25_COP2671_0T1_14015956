using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 10f; //Adjust the speed of ball
    public Transform cameraTransform;  // Reference Camera
    private Rigidbody rb; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    void FixedUpdate()
    {
        // Get input from WASD or arrow keys
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Get the forward and right directions relative to the camera
        Vector3 cameraForward = cameraTransform.forward;
        Vector3 cameraRight = cameraTransform.right;


        // Flatten the directions (ignore the y-axis)
        cameraForward.y = 0f;
        cameraRight.y = 0f;

        // Normalize to ensure consistent movement speed
        cameraForward.Normalize();
        cameraRight.Normalize();

        // Calculate movement direction based on input and camera orientation
        Vector3 movement = (cameraForward * moveVertical) + (cameraRight * moveHorizontal);

        // Apply movement to the Rigidbody
        rb.AddForce(movement * moveSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
