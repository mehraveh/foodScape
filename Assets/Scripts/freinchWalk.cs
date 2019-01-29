﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freinchWalk : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    public GameObject chef;
    public GameObject gameOver;
    public bool gotKey;
    public bool hasEnter;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        if (isGrounded == true && Input.GetKeyDown("w"))
        {
            rb.velocity = Vector2.up * jumpForce;
        }

        if (Input.GetKey("a"))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        float xDistant = Mathf.Abs(chef.transform.position.x - this.transform.position.x);
        float yDistant = chef.transform.position.y - this.transform.position.y;
        if (xDistant > 0 && xDistant < 1.5 && yDistant > 0 && yDistant < 0.5)
        {
            gameOver.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}