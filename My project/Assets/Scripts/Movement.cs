using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;

    private Vector2 movementInput;
    private Rigidbody2D rb2D;

    private Animator animator;


    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        movementInput.x = Input.GetAxisRaw("Horizontal");
        movementInput.y = Input.GetAxisRaw("Vertical");

        movementInput = movementInput.normalized;

        animator.SetFloat("Horizontal",movementInput.x);
        animator.SetFloat("Vertical", movementInput.y);
        animator.SetFloat("Speed", movementInput.magnitude);
    }

    private void FixedUpdate()
    {
        rb2D.velocity = movementInput * speed;
    }


}
