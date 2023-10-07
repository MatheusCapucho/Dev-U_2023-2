using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AnimatorController : MonoBehaviour
{
    protected Animator _anim;

    private string _currentState;

    [Header("Nome da Animação")]
    [SerializeField] private string idle;
    [SerializeField] private string jump;
    [SerializeField] private string run;
    [SerializeField] private string fall;

    public string IDLE => idle;
    public string FALL => fall;
    public string JUMP => jump;
    public string RUN => run;


    protected virtual void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    protected void ChangeAnimation(string newState)
    {
        if (_currentState == newState) return;


        _anim.Play(newState);
        _currentState = newState;
    }

}
