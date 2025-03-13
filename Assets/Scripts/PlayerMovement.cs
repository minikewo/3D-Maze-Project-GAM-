using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // we put information at the start
    // of a class
    
    public float speed = 4.5f;
    public float jumpForce = 5; 
    public string hero = "Peepee";
    
    
    // xyz coordinates
    public Vector3 direction;
    public Rigidbody playerRb;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("My name is " + hero);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // the dot is there to access
        // a functionality of "transform"
        //transform.Translate(direction * Time.deltaTime * speed, Space.World);

        Vector3 velocity = direction * speed;
        velocity.y = playerRb.linearVelocity.y;

        playerRb.linearVelocity = velocity;
    }

    private void OnMove(InputValue value)
    {
        // Asks the input system 
        // what keys are being pressed
        Vector2 inputValue = value.Get<Vector2>();
        direction = new Vector3(
            inputValue.x,
            0,
            inputValue.y
        );
        
        transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
    }

    private void OnJump(InputValue value)
    {
        // Physics.Raycast willcast a line that can hit opther colliders
        //if it finds a collider, it returns true, if it doesnt it returns false
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, maxDistance: 0.6f);
        if (isGrounded)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        
    }
}