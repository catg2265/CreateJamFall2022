using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private Animator anim;

    private Vector2 movement;

    public float speed = 5f;

    public bool canMove = true;
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if (canMove)
        {
            rb.MovePosition(rb.position + movement * (speed * Time.fixedDeltaTime));
        }
    }
}
