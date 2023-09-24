using System.Collections;
using System.Collections.Generic;
using System.IO;
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
