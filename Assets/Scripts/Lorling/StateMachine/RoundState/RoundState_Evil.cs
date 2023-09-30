using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "RoundState_Evil", menuName = "Data/StateMachine/RoundState/RoundState_Evil")]
public class RoundState_Evil : RoundState
{
    bool isAppear;
    int random;

    public override void Enter()
    {   

        // 好事件充能
        random = Mathf.Abs((int)Random.value % 10);
        PlayerAttribute.Instance.goodSchedule = Mathf.Min(100, PlayerAttribute.Instance.goodSchedule + ((random == 0) ? 10 : 0));
        PlayerAttribute.Instance.canGoodEvent = PlayerAttribute.Instance.goodSchedule == 100;

        // TODO::从事件池中读取事件
        int randomproperty = Random.Range(0, 100);
        if (randomproperty >= 90)
        {
            int randomid = Random.Range(0, stateMachine.EventListBad.Count() - 1);
            stateMachine.EffectedEvent.Add(stateMachine.EventListBad[randomid]);
        }


    }

    public override void Exit()
    {
        stateMachine.SwitchState(typeof(RoundState_Produce));
    }
}
