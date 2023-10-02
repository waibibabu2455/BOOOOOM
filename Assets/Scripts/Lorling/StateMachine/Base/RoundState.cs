using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundState : ScriptableObject, IState
{
    protected RoundStateMachine stateMachine;

    public void Initialize(RoundStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }

    public virtual void Enter()
    {

    }

    public virtual void Exit() 
    {

    }

    public virtual void Update()
    {

    }

    public virtual void SetButton(ButtonUIBase button)
    {

    }
}
