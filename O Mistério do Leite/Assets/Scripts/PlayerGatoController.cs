using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGatoController : MonoBehaviour
{
    private float RunSpeed = 15f; //10
    private float JumpingPower = 20f; //20    
    private float HorizontalMove;
    private bool IsFacingRight = true;
    //private bool IsJumping = false;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform GroundCheck;
    [SerializeField] private Transform CeilingCheck;
    [SerializeField] private LayerMask GroundLayer;
    [SerializeField] private BoxCollider2D bc;
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMove = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded() && !IsTouchingCeiling())
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpingPower);
            GetComponent<Animator>().SetBool("IsJumping", true);
        }
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.3f);
        if (IsGrounded())
            GetComponent<Animator>().SetBool("IsJumping", false);
        Flip();
    }

    private void FixedUpdate()
    {
        if (IsGrounded() || !IsGrounded() && !rb.IsTouchingLayers(GroundLayer))
        {
            rb.velocity = new Vector2(HorizontalMove * RunSpeed, rb.velocity.y);
            GetComponent<Animator>().SetFloat("Speed", Mathf.Abs(HorizontalMove * RunSpeed));

        }
    }

    private bool IsGrounded()
    {
        //verifica se personagem está no chão
        return Physics2D.OverlapCircle(GroundCheck.position, 0.2f, GroundLayer);
    }

    private bool IsTouchingCeiling()
    {
        return Physics2D.OverlapCircle(CeilingCheck.position, 0.5f, GroundLayer);
    }

    private void Flip()
    {
        if (IsFacingRight && HorizontalMove < 0 || !IsFacingRight && HorizontalMove > 0)
        {
            IsFacingRight = !IsFacingRight;
            Vector3 LocalScale = transform.localScale;
            LocalScale.x *= -1f;
            transform.localScale = LocalScale;
        }
    }
}
