using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArickMove : MonoBehaviour

{
    Rigidbody2D rb2D;

    public float runSpeed = 2;
    public float jumpSpeed = 3;  

    public bool betterjump = false;
    public float fallMultiplayer = 0.5f;
    public float lowjumpMultiplayer = 1f;
    public SpriteRenderer spriteRenderer;
   
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
            spriteRenderer.flipX = false;
        }
        else if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
            spriteRenderer.flipX = true;
        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
        }

        if (Input.GetKey("space") && CheckGround.isGrounded)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
        }

        if (betterjump)
        {
            if (rb2D.velocity.y < 0)
            {
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplayer) * Time.deltaTime;
            }
            if (rb2D.velocity.y > 0 && !Input.GetKey("space"))
            {
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (lowjumpMultiplayer) * Time.deltaTime;
            }
        }

    }
}
