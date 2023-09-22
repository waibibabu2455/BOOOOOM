using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoundState_Initial", menuName = "Data/StateMachine/RoundState/RoundState_Initial")]
public class RoundState_Initial : RoundState
{
    int eventCount;
    int random;

    public override void Enter()
    {
        random = Mathf.Abs((int)Random.value % 100);
        if (random < 20) eventCount = 1;
        else if (random < 80) eventCount = 2;
        else eventCount = 3;

        // TODO::从事件池中读取事件
    }

    public override void Exit()
    {
        stateMachine.SwitchState(typeof(RoundState_Evil));
    }
}