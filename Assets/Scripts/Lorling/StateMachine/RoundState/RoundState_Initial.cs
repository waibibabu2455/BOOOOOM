using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "RoundState_Initial", menuName = "Data/StateMachine/RoundState/RoundState_Initial")]
public class RoundState_Initial : RoundState
{
    int eventCount;
    int random;

    private void Start()
    {
        
    }
    public override void Enter()
    {

        // TODO::从事件池中读取事件
        int randomid = Random.Range(0, stateMachine.EventListNormal.Count()-1);
        stateMachine.EventListNormal[randomid].effect();


    }

    public override void Exit()
    {
        stateMachine.SwitchState(typeof(RoundState_Evil));
    }

}