using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movespeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {

        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * movespeed;
        rb.velocity = new Vector2(moveBy, rb.velocity.y);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(rb.velocity.x, movespeed);
        }
    }
}
