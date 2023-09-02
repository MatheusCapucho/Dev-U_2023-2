using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovingState : IBaseState
{
    private Vector3 randomPosition;
    private Vector3 direction;

    public void EnterState(EnemyStateMachine stateMachine)
    {
        
    }

    public void UpdateState(EnemyStateMachine stateMachine)
    {
        var wasd = stateMachine.input.Player.Move.ReadValue<Vector2>();

        Debug.Log(wasd);

        if (wasd.x == 1f)
            stateMachine.SwitchState(new ShootingState());

    }
   

}
