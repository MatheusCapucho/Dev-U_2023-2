using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private Animator _anim;
    private int _currentState = 0;

    private readonly int IDLE = Animator.StringToHash("Idle");
    private readonly int JUMP = Animator.StringToHash("Jump");
    private readonly int RUN = Animator.StringToHash("Run");
    private readonly int FALL = Animator.StringToHash("Fall");


    void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    void Update()
    {
        var state = NewState();
    }

    private int NewState()
    {
        return 0;
    }
}
