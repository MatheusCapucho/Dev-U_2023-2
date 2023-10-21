using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class PlayerMovementController : AnimatorController
{
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private float _direction;
    private bool isJumping = false;


    [Header("Plyer Attributes")]
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 6f;

    private PlayerControls inputs;
    protected override void Awake()
    {
        base.Awake();
        inputs = new PlayerControls();
        inputs.Enable();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }
    private void OnEnable()
    {
        inputs.Player.Move.performed += GetMoveDirection;
        inputs.Player.Move.canceled += GetMoveDirection;
        inputs.Player.Jump.performed += Jump;
    }
    private void OnDisable()
    {
        inputs.Player.Move.performed -= GetMoveDirection;
        inputs.Player.Move.canceled -= GetMoveDirection;
        inputs.Player.Jump.performed -= Jump;
    }
    private void Jump(InputAction.CallbackContext context)
    {
        if (isJumping) return;

        ChangeAnimation(JUMP);
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        isJumping = true;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(_direction * speed, rb.velocity.y);
        if(rb.velocity.y < -.6f)
        {
            ChangeAnimation(FALL);
        }
    }

    private bool _isFacingRight = true;
    private void GetMoveDirection(InputAction.CallbackContext context)
    {
        _direction = MathF.Round(context.ReadValue<Vector2>().x);

        if (_isFacingRight && _direction < 0) { sr.flipX = true; _isFacingRight = !_isFacingRight; }
        else if (!_isFacingRight && _direction > 0) { sr.flipX = false; _isFacingRight = !_isFacingRight; }

        if (_direction != 0)
        {
            ChangeAnimation(RUN);
        }
        else
        {
            ChangeAnimation(IDLE);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJumping = false;
        ChangeAnimation(IDLE);
    }

}
