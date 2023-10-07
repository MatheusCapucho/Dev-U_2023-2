using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCommand : ICommand
{
    private Rigidbody2D rb;
    private GameObject player;
    public JumpCommand(GameObject player, Rigidbody2D rb)
    {
        this.player = player;
        this.rb = rb;
    }
    public void Execute()
    {
        rb.AddForce(Vector2.up * 5f, ForceMode2D.Impulse);
    }

    public void Undo()
    {

    }
}
