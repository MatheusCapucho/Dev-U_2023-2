using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : ICommand
{
    private Vector2 direction;
    private GameObject player;

    private Vector2 previusDirection;
    public MoveCommand(GameObject player, Vector2 direction)
    {
        this.player = player;
        this.direction = direction;
    }
    public void Execute()
    {
        player.transform.position += (Vector3)direction;
        previusDirection = direction;
    }

    public void Undo()
    {
        player.transform.position -= (Vector3)previusDirection;
    }
}
