using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IBaseState
{
    float i=0;
    public void EnterState(EnemyStateMachine stateMachine)
    {
        Debug.Log("Entrei no Idle State");
    }

    public void UpdateState(EnemyStateMachine stateMachine)
    {
        i++;
        if (i > 1000)
            stateMachine.SwitchState(new MovingState());
    }
}
