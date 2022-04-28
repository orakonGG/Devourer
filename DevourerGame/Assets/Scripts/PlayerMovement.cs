using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 8f;
    public float jumpOomph = 8f;
    private float direction = 0f;

    private Rigidbody2D rb;

    public Animator animator;

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
        // ground check and animator
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        if (isTouchingGround)
        {
            animator.SetBool("isJumping", false);
        }

        // WASD/arrow key input
        direction = Input.GetAxis("Horizontal");
        
        //Debug.Log(direction);

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
        // animate jump
        if (Mathf.Abs(rb.velocity.y) > 0.01)
        {
            animator.SetBool("isJumping", true);
        }

        // animate run
        animator.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
    }



}
