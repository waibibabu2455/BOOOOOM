using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoundState_Free", menuName = "Data/StateMachine/RoundState/RoundState_Free")]
public class RoundState_Free : RoundState
{
    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit() 
    { 
        stateMachine.SwitchState(typeof(RoundState_End));
    }
}
