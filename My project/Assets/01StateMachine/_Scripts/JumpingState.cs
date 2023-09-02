using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingState : IBaseState
{
    private float timeBetweenJumps = 1f;
    private float lastJumpTime = 0f;
    private float jumpForce = 5f;

    private int jumpCount = 0;

    private Rigidbody rb;

    public void EnterState(EnemyStateMachine stateMachine)
    {
        
        rb = stateMachine.GetComponent<Rigidbody>();
        lastJumpTime = Time.time;
        
    }
    public void UpdateState(EnemyStateMachine stateMachine)
    {
        
        if (Time.time > lastJumpTime + timeBetweenJumps)
        {
            lastJumpTime = Time.time;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpCount++;
        }

        if (jumpCount > 2f)
            stateMachine.SwitchState(new ShootingState());

    }

}
