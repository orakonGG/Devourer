using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 8f;
    public float jumpOomph = 8f;
    private float direction = 0f;

    private Rigidbody2D rb;

    // jump conditions
    public Transform groundCheck;
    public float groundCheckRadius = 0.4f;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    

    // called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }



    // player input moving the object
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        // WASD/arrow key input
        direction = Input.GetAxis("Horizontal");
        Debug.Log(direction);
        if (direction > 0f)
        {
            rb.velocity = new Vector2(direction * speed, rb.velocity.y);
        }
        else if (direction < 0f)
        {
            rb.velocity = new Vector2(direction * speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        // jump if spacebar pressed and player is grounded
        if (Input.GetButtonDown("Jump") && isTouchingGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpOomph);
        }

        // melee attack input
        if(Input.GetKeyDown("v"))
        {
            // PlayerCombat call
        }
    }



}
