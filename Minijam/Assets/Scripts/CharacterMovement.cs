using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    public bool canJump = false;
    public bool isInDialogue = true;
    public float speed;
    public float jumpSpeed;
    public int firstQuestion = 0;
    private Shoot shootManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        shootManager = GetComponent<Shoot>();
    }
    private void Update()
    {
		if (!isInDialogue && Input.GetKeyDown(KeyCode.Mouse0))
		{
            shootManager.Fire();
		}
	}
    void FixedUpdate()
    {
        if (!isInDialogue)
        {
			float moveInput = Input.GetAxis("Horizontal");
			rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
		}
        if (Input.GetKey(KeyCode.Space)) Jump();
    }

    void Jump()
    {
        if (canJump && !isInDialogue)
        {
            canJump = false;
            rb.velocity = Vector2.up * jumpSpeed;
            //rb.AddForce(Vector2.up*jumpSpeed, ForceMode2D.Force);
            //animator.SetBool("isJumping", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            canJump = true;
        } 

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Platform")) canJump = false;
    }
}
