using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHumanaController : MonoBehaviour
{
    private float RunSpeed = 10f; //10
    //private float JumpingPower = 25f; //20
    private float HorizontalMove;
    private bool IsFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform GroundCheck;
    [SerializeField] private Transform CeilingCheck;
    [SerializeField] private LayerMask GroundLayer;
    [SerializeField] private BoxCollider2D bc;
    [SerializeField] private CircleCollider2D cc;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMove = Input.GetAxisRaw("Horizontal");
        Flip();


    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(HorizontalMove * RunSpeed, rb.velocity.y);
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
