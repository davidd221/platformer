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
        List < ContactPoint2D > contacts = new List <ContactPoint2D>();
        if (rb.GetContacts(contacts) != 0)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.velocity = new Vector2(rb.velocity.x, movespeed);
            }
        }
    }
}



//using UnityEngine;
//
//public class Example : MonoBehaviour
//{
//    CharacterController controller;
//
//    void Start()
//    {
//        controller = GetComponent<CharacterController>();
//    }
//
//    void Update()
//    {
//        if (controller.isGrounded)
//        {
//            print("CharacterController is grounded");
//        }
//    }
//}