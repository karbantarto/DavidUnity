using UnityEngine;

public class SpaceShipMovement : MonoBehaviour
{
    [SerializeField] float angularSpeed = 180f;
    [SerializeField] float maxSpeed = 2f;
    [SerializeField] float acceleration = 1;
    [SerializeField] float drag = 0.5f;

    Vector3 velocity;


    void FixedUpdate()
    {
        

        //gyorsulas
        float movementInput = Input.GetAxisRaw("Vertical");
        if (movementInput > 0)
        {
            Vector3 globalDirection = transform.up * movementInput;
            velocity += globalDirection * acceleration * Time.fixedDeltaTime;

            velocity = Vector3.ClampMagnitude(velocity, maxSpeed);

        }
        //kozegellenallas
        Vector3 dragAcceleration = -velocity * drag;
        velocity += dragAcceleration * Time.fixedDeltaTime;


        
    }

    void Update()
    {
        //fordulas
        float rotationInput = -Input.GetAxisRaw("Horizontal");
        transform.Rotate(0, 0, rotationInput * angularSpeed * Time.deltaTime); 
        
        //mozgas
        transform.position += velocity * Time.deltaTime;
    }

}
