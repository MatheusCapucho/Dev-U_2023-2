using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

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
        //GetMoveInput();
        CurrentState.UpdateState(this);
    }

    public Vector2 GetMoveInput()
    {
        return input.Player.Move.ReadValue<Vector2>();
    }

    public void SwitchState(IBaseState baseState)
    {
        CurrentState = baseState;
        CurrentState.EnterState(this);
    }

}
