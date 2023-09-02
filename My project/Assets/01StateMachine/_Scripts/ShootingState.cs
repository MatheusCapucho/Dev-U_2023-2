using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ShootingState : IBaseState
{
    private float lastShootTime;
    private float cooldown = .5f;
    int contador = 0;
    int rng;

    private GameObject bulletPrefab;
    public void EnterState(EnemyStateMachine stateMachine)
    {
        bulletPrefab = (GameObject)Resources.Load("Bullet");

         rng = Random.Range(0, 2);
    }
    public void UpdateState(EnemyStateMachine stateMachine)
    { 
        if (Time.time > lastShootTime + cooldown)
        {
            lastShootTime = Time.time;
            GameObject.Instantiate(bulletPrefab, stateMachine.transform);
            contador++;
        } 

        if(contador > 5)
        {
            if (rng == 0)
                stateMachine.SwitchState(new MovingState());
            else
                stateMachine.SwitchState(new JumpingState());
        }

    }

}
