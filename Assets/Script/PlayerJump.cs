using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float forceJump;
    public bool isJumping;
    public bool isGrounded;

    private Rigidbody2D rigidbody2d;

    public Transform groundCheckLeft;
    public Transform groundCheckRight;

    public Animator animator;

    public GameObject panelGameOver;

    void Start()
    {
        isJumping = false;
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapArea(groundCheckLeft.position, groundCheckRight.position); 
        if (Input.GetMouseButton(0) && isGrounded)
        {
            isJumping = true;
        }
        gameObject.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));

        Jump();
    }

    public void Jump()
    {
        animator.SetBool("jump", !isGrounded);
        if(isJumping)
        {
            rigidbody2d.velocity = Vector2.up * forceJump;
            isJumping = !isJumping;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
            panelGameOver.SetActive(true);
    }
}
