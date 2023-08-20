using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingState : IBaseState
{
    private Vector3 randomPosition;
    private Vector3 direction;

    public void EnterState(EnemyStateMachine stateMachine)
    {
        float randomFloat = Random.Range(-4f, 4f);
        randomPosition = new Vector3(randomFloat, 1f, randomFloat);
        direction = (randomPosition - stateMachine.transform.position).normalized;
    }

    public void UpdateState(EnemyStateMachine stateMachine)
    {
        stateMachine.transform.position += direction * Time.deltaTime;

        if (Vector3.Distance(stateMachine.transform.position, randomPosition) < 0.1f)
            stateMachine.SwitchState(new JumpingState());

    }
}
