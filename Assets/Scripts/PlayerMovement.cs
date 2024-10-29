using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontalInput; // Variable to store the player's horizontal input
    private float xRange = 5; // Range for player movement limits

    // ENCAPSULATION
    protected float speed; // default speed and set to private and will be inherited later 

    void Start()
    {
        SetSpeed();
    }
    // Update is called once per frame
    void Update()
    {
        PlayerController(); // this is abstraction
    }

    public void PlayerController() // ABSTRACTION
    {
        horizontalInput = Input.GetAxis("Horizontal"); // Get horizontal input
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput); // Move player

        if (transform.position.x < -xRange) // Check left boundary
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); // Clamp position
        }

        if (transform.position.x > xRange) // Check right boundary
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z); // Clamp position
        }
    }

    public virtual void SetSpeed()
    {
        speed = 5f;
    }
}
