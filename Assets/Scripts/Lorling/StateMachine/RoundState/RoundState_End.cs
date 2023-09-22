using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoundState_End", menuName = "Data/StateMachine/RoundState/RoundState_End")]
public class RoundState_End : RoundState
{
    public override void Enter()
    {
        PlayerAttribute.Instance.score -= PlayerAttribute.Instance.consume;
    }

    public override void Exit()
    {
        stateMachine.SwitchState(typeof(RoundState_Initial));
    }
}
