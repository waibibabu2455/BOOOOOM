using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoundState_Evil", menuName = "Data/StateMachine/RoundState/RoundState_Evil")]
public class RoundState_Evil : RoundState
{
    bool isAppear;
    int random;

    public override void Enter()
    {
        random = Mathf.Abs((int)Random.value % 10);
        isAppear = (random == 0);

        // TODO::���¼����ж�ȡ�¼�
    }

    public override void Exit()
    {
        stateMachine.SwitchState(typeof(RoundState_Produce));
    }
}
