using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoundState_Free", menuName = "Data/StateMachine/RoundState/RoundState_Free")]
public class RoundState_Free : RoundState
{
    ButtonUIBase button;

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit() 
    {
        if (this.button != null) button.Exit();
        stateMachine.SwitchState(typeof(RoundState_End));
    }

    public override void SetButton(ButtonUIBase button)
    {
        if(this.button != null) this.button.Exit();
        this.button = button;
        //this.button.Enter();
    }
}
