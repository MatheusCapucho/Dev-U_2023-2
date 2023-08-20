using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateMachine : MonoBehaviour
{
    public IBaseState CurrentState { get; private set; }

    public float Speed = 5f;
    
    private void Start()
    {
        SwitchState(new IdleState());
    }

    private void Update()
    {
        CurrentState.UpdateState(this);
    }

    public void SwitchState(IBaseState baseState)
    {
        CurrentState = baseState;
        CurrentState.EnterState(this);
    }

}
