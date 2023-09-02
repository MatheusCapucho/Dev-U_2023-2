using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateMachine : MonoBehaviour
{
    public IBaseState CurrentState { get; private set; }

    public PlayerControls input { get; private set; }

    private void Awake()
    {
        input = new PlayerControls();
    }

    private void OnEnable()
    {
        input.Enable();
    }
    private void OnDisable()
    {
        input.Disable();
    }

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
