using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    [SerializeField] private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the Vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * GameManager.Instance.speed * forwardInput);
        // Rotates car based on horizontal inputs
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}