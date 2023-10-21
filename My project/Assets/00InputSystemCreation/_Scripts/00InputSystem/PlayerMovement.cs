using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField]
    private float speed = 50f;

    private PlayerControls inputs;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        inputs = new PlayerControls();

    }

    private void OnEnable()
    {
        inputs.Enable();
        inputs.Player.Move.performed += MoveAction;
        //inputs.Player.Move.started += MoveAction;
        //inputs.Player.Move.canceled += MoveAction;
    }

    private void OnDisable()
    {
        inputs.Disable();
        inputs.Player.Move.performed -= MoveAction;
        //inputs.Player.Move.canceled -= MoveAction;
    }

    private void Update()
    {
    }

    private void Move(Vector2 movementDirection)
    {
        //rb.velocity = new Vector3(movementDirection.x, -1f, movementDirection.y) * speed;
    }

    private void MoveAction(InputAction.CallbackContext ctx)
    {
        var movementDirection = ctx.ReadValue<Vector2>();
        rb.velocity = new Vector3(movementDirection.x, -1f, movementDirection.y) * speed;
    }

}
