using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoundState_Effect", menuName = "Data/StateMachine/RoundState/RoundState_Effect")]
public class RoundState_Effect : RoundState
{
    public override void Enter()
    {
        base.Enter();
        for (int i = 0; i <= stateMachine.EffectedEvent.Count - 1; i++)
        {
            stateMachine.EffectedEvent[i].effect();
            stateMachine.EffectedEvent[i].maintainedround -= 1;
            if (stateMachine.EffectedEvent[i].maintainedround <= 0)
            {
                stateMachine.EffectedEvent.Remove(stateMachine.EffectedEvent[i]);
            }
        }
    }

    public override void Exit()
    {



        stateMachine.SwitchState(typeof(RoundState_End));
    }
}
