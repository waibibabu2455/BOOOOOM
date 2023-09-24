using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoundState_Produce", menuName = "Data/StateMachine/RoundState/RoundState_Produce")]
public class RoundState_Produce : RoundState
{
    public override void Enter()
    {
        PlayerAttribute.Instance.score += PlayerAttribute.Instance.getScore;
    }

    public override void Exit()
    {
        stateMachine.SwitchState(typeof(RoundState_Free));
    }
}
