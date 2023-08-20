using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] private float jumpForce;

    private PlayerControls inputs;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        inputs = new PlayerControls();
    }
    private void OnEnable()
    {
        inputs.Enable();
        inputs.Player.Jump.performed += Jump;
    }

    private void OnDisable()
    {
        inputs.Disable();
    }
    private void Jump(InputAction.CallbackContext ctx)
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
} 
