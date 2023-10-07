using System;
using UnityEditor;
using UnityEngine;

public class Player2DMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isJumping = false;

    private float speed = 1f;
    private float jumpForce = 6f;

    private Executor myMovements;
    private PlayerControls inputs;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        inputs.Enable();
    }

    private void Start()
    {
        myMovements = new Executor();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            
            ICommand command = new MoveCommand(this.gameObject, Vector2.right);
            //command.Execute();
            myMovements.AddAndExecuteCommand(command);
            //myMovements.AddCommand(command);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            
            ICommand command = new MoveCommand(this.gameObject, Vector2.left);
            //command.Execute();
            myMovements.AddAndExecuteCommand(command);
            //myMovements.AddCommand(command);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            ICommand command = new JumpCommand(this.gameObject, rb);
            //command.Execute();
            myMovements.AddAndExecuteCommand(command);
            //myMovements.AddCommand(command);
        }

        if(Input.GetKeyDown(KeyCode.M))
        {
            myMovements.ExecuteAll();
        }

        if (Input.GetKeyDown(KeyCode.U))
        { 
            myMovements.UndoCommand();
        }


    }

}
