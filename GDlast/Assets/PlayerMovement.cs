using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
// 2d horizontal movement

    public float speed = 5f;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal") * speed;
        Vector2 move = new Vector2(x, rb.velocity.y);
        rb.velocity = move;
        // jump
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }

        // get child box collider
        BoxCollider2D boxCollider = GetComponent<BoxCollider2D>();
        // check trigger collision
        if (boxCollider.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            Debug.Log("Touching ground");
        }

    }



}
