using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{

    [Header("Rigidbody Settings")]
    [Tooltip("Rigidbody2D object that is stored")]
    public Rigidbody2D rb;
    [Tooltip("Downward speed of the object")]
    public float downSpeed = 20f;
    [Header("Movement Settings")]
    [Tooltip("Movement speed of the object")]
    public float movementSpeed = 10f;
    [Tooltip("Movement direction of the object")]
    public float movement = Of;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        //Flip the sprite based on movement direction
        spriteRenderer.flipX = movement < 0;
    }
    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        //Velocity of the x axis equals to
        //the direction movement on the x axis
        // of the character.
        velocity.x = movement;
        //Rigidbody2D velocity equals to
        //velocity of the object
        rb.velocity = velocity;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If the object collides with something and is moving downwards,
        // adjust the y-component of its velocity
        if (rb.velocity.y <= 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, downSpeed);
        }

    }
    }

